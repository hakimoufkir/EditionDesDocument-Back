using Domain.Dtos;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.TraineeFeature.Commands.AddTrainee
{
    public class AddTraineeCommand : IRequest<TraineeDto>
    {
        public TraineeDto Trainee { get; set; }

        public AddTraineeCommand(TraineeDto trainee)
        {
            Trainee = trainee;
        }
    }
}
