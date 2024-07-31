using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.TraineeFeature.Queries.GetTraineesList
{
    public class GetTraineesListQueryHandler : IRequestHandler<GetTraineesListQuery, List<Trainee>>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;

        public GetTraineesListQueryHandler(IUnitOfService unitOfService, IMapper mapper)
        {
            _unitOfService = unitOfService;
            _mapper = mapper;
        }


        public async Task<List<Trainee>> Handle(GetTraineesListQuery request, CancellationToken cancellationToken)
        {

            try
            {
                List<Trainee> trainees = await _unitOfService.TraineeService.GetTraineesList();
                return trainees;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"An error occurred while retrieving Trainees. Details: {ex.Message} {ex.StackTrace}", ex);
            }
        }
    }
}
