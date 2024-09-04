using Application.Broker.Producer;
using Application.IServices;
using Application.IUnitOfWorks;
using AutoMapper;
using Domain.Dtos;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Application.Services
{
    public class TraineeService : ITraineeService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ListTraineeProducer _listTraineeProducer ;

        public TraineeService(IUnitOfWork unitOfWork , IMapper mapper, ListTraineeProducer listTraineeProducer)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _listTraineeProducer = listTraineeProducer;
        }


        public async Task<TraineeDto> AddTraineeAsync(TraineeDto trainee)
        {
            if (trainee == null)
            {
                throw new ArgumentNullException(nameof(trainee), "trainee cannot be null.");
            }

            var trainees = _mapper.Map<Trainee>(trainee);
            await _unitOfWork.TraineeRepository.CreateAsync(trainees);
            await _unitOfWork.CommitAsync();
            return trainee;
        }

     

        public async Task<Trainee> GetTraineeByIdAsync(Guid IdTrainee)
        {
            Trainee trainee = await _unitOfWork.TraineeRepository.GetAsNoTracking(u => u.Id == IdTrainee);
            if (trainee == null)
            {
                throw new ArgumentException(ResponsStutusHandler.StatusMessages.InternalServerError);
            }
            return trainee;
        }

        public async Task<List<Trainee>> GetTraineesList()
        {
            List<Trainee> TraineesList = await _unitOfWork.TraineeRepository.GetAllAsNoTracking();
            if (TraineesList == null)
            {
                throw new ArgumentException("No Trainees found.");
            }
            return TraineesList;
        }

        public async Task UpdateTraineeAsync(Trainee trainee)
        {
            if (trainee == null)
            {
                throw new ArgumentNullException(nameof(trainee));
            }

            Trainee existingtrainee = await _unitOfWork.TraineeRepository.GetAsNoTracking(
                d => d.Id == trainee.Id);
            if (existingtrainee == null)
            {
                throw new ArgumentException("trainee not found.");
            }

            existingtrainee.FirstName = trainee.FirstName;
            existingtrainee.LastName = trainee.LastName;

            try
            {
                await _unitOfWork.TraineeRepository.UpdateAsync(existingtrainee);
                await _unitOfWork.CommitAsync();
            }
            catch (Exception ex)
            {

                throw new ArgumentException($"Exception: {ex.Message}\nStackTrace: {ex.StackTrace}");
            }
        }

        public async Task DeleteTraineeAsync(Guid IdTrainee)
        {
           
            Trainee trainee = await _unitOfWork.TraineeRepository.GetAsNoTracking(u => u.Id == IdTrainee);
            if (trainee == null)
            {
                throw new ArgumentException("Trainee not found.");
            }

            try
            {
               
                await _unitOfWork.TraineeRepository.RemoveAsync(trainee);
                await _unitOfWork.CommitAsync();
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Exception: {ex.Message}\nStackTrace: {ex.StackTrace}");
            }
        }


        public async Task<List<Trainee>> GetListTraineesFormKafkaAsync()
        {
            // Produce the message to Kafka
            await _listTraineeProducer.ProduceAsync("InscriptionServiceRequestMiddleWare", "ListTrainees");

            // Wait until the trainees are loaded
            if (!StaticTrainee.LoadingTask.IsCompleted)
            {
                await StaticTrainee.LoadingTask;
            }

            // Reset the loading task for the next request
            StaticTrainee.ResetLoading();

            // Return the trainee list
            return StaticTrainee.GetTraineeList();
        }
    }
}
