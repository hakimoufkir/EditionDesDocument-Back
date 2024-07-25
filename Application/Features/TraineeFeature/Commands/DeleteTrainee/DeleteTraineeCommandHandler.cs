using Application.IServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.TraineeFeature.Commands.DeleteTrainee
{
    public class DeleteTraineeCommandHandler : IRequestHandler<DeleteTraineeCommand, string>
    {
        private readonly ITraineeService _traineeService;

        public DeleteTraineeCommandHandler(ITraineeService traineeService)
        {
            _traineeService = traineeService;
        }

        public async Task<string> Handle(DeleteTraineeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await _traineeService.DeleteTraineeAsync(request.Id);
                return "Trainee deleted successfully";
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception: {ex.Message}\nStackTrace: {ex.StackTrace}");
            }
        }

    }
}
