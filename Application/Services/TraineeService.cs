using Application.IServices;
using Application.IUnitOfWorks;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Application.Services
{
    public class TraineeService : ITraineeService
    {

        private readonly IUnitOfWork _unitOfWork;

        public TraineeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<Trainee> AddTraineeAsync(Trainee trainee)
        {
            if (trainee == null)
            {
                throw new ArgumentNullException(nameof(trainee), "trainee cannot be null.");
            }

            await _unitOfWork.TraineeRepository.CreateAsync(trainee);
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
            // Check if the trainee exists
            Trainee trainee = await _unitOfWork.TraineeRepository.GetAsNoTracking(u => u.Id == IdTrainee);
            if (trainee == null)
            {
                throw new ArgumentException("Trainee not found.");
            }

            try
            {
                // Delete the trainee
                await _unitOfWork.TraineeRepository.RemoveAsync(trainee);
                await _unitOfWork.CommitAsync();
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Exception: {ex.Message}\nStackTrace: {ex.StackTrace}");
            }
        }


    }
}
