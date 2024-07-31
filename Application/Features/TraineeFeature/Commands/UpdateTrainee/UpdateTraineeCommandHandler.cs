using Application.IRepository;
using Application.IServices;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.TraineeFeature.Commands.UpdateTrainee
{
    public class UpdateTraineeCommandHandler : IRequestHandler<UpdateTraineeCommand,string>
    {
        private readonly IMapper _mapper;
        private readonly ITraineeService _traineeService;

        public UpdateTraineeCommandHandler(ITraineeService traineeService,IMapper mapper)
        {
            _mapper = mapper;
            _traineeService = traineeService;
        }

        public async Task<string> Handle(UpdateTraineeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Trainee trainee = _mapper.Map<Trainee>(request);
                await _traineeService.UpdateTraineeAsync(trainee);
                return "Trainee updated successfully";
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception: {ex.Message}\nStackTrace: {ex.StackTrace}");
            }
        }
    }
}
