using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.TraineeFeature.Commands.UpdateTrainee
{
    public class UpdateTraineeCommand : IRequest<string>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public UpdateTraineeCommand(Guid id , string firstName, string lastName)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
        }
    }
}
