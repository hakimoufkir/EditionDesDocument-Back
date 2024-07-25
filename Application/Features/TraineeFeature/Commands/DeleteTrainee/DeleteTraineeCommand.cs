using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.TraineeFeature.Commands.DeleteTrainee
{
    public class DeleteTraineeCommand : IRequest<string>
    {
        public Guid Id { get; set; }

        public DeleteTraineeCommand(Guid id)
        {
            Id = id;
        }
    }
}
