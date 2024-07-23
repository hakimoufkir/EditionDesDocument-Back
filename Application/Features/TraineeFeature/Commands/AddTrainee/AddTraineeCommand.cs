using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.TraineeFeature.Commands.AddTrainee
{
    public class AddTraineeCommand : IRequest<Trainee>
    {
        public Trainee Trainee { get; set; }

        public AddTraineeCommand(Trainee trainee)
        {
            Trainee = trainee;
        }
    }
}
