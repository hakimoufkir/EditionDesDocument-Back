using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.TraineeFeature.Queries.GetTraineeById
{
    public class GetTraineeByIdQueryHandler : IRequestHandler<GetTraineeByIdQuery, Trainee>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;

        public GetTraineeByIdQueryHandler(IUnitOfService unitOfService, IMapper mapper)
        {
            _unitOfService = unitOfService;
            _mapper = mapper;

        }


        public async Task<Trainee> Handle(GetTraineeByIdQuery request, CancellationToken cancellationToken)
        {
            Trainee result = await _unitOfService.TraineeService.GetTraineeByIdAsync(request.IdTrainee);
            return result;
        }
    }
}
