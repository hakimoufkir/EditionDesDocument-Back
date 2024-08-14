 using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.TraineeFeature.Queries.GetTraineeById
{
    public class GetTraineeByIdQuery : IRequest<Trainee>
    {

        public Guid IdTrainee { get; set; }

        public GetTraineeByIdQuery(Guid idTrainee)
        {
            IdTrainee = idTrainee;
        }
    }
}
