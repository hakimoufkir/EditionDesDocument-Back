using Application.IServices;
using Application.Services;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.TraineeFeature.Commands.AddTrainee
{
    public class AddTraineeCommandHandler : IRequestHandler<AddTraineeCommand, Trainee>
    {
        private readonly ITraineeService _traineeService;

        public AddTraineeCommandHandler(ITraineeService traineeService)
        {
            _traineeService = traineeService ?? throw new ArgumentNullException(nameof(traineeService));
        }



        public async Task<Trainee> Handle(AddTraineeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                if (request.Trainee == null)
                {
                    throw new ArgumentNullException(nameof(request.Trainee), "Trainee cannot be null.");
                }

                Trainee addedTrainee = await _traineeService.AddTraineeAsync(request.Trainee);
                return addedTrainee;
            }
            catch (Exception ex)
            {
                // Log the exception details
                throw new ApplicationException($"An error occurred while adding the Trainee. Details: {ex.Message} {ex.StackTrace}", ex);
            }
        }
    }
}
