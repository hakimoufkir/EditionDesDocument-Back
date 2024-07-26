using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.RequestFeature.Queries.GetRequestsList
{
    public class GetRequestsListQueryHandler : IRequestHandler<GetRequestsListQuery, List<Request>>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;

        public GetRequestsListQueryHandler(IUnitOfService unitOfService, IMapper mapper)
        {
            _unitOfService = unitOfService;
            _mapper = mapper;
        }

        public async Task<List<Request>> Handle(GetRequestsListQuery request, CancellationToken cancellationToken)
        {
          
            int page = 1; 
            int pageSize = 100; 

            List<Request> requests = await _unitOfService.RequestService.GetPagedRequestsAsync(page, pageSize);
            return requests;
        }
    }
}
