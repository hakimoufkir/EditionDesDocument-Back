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
        private readonly IRequestService _requestService; 
        private readonly IMapper _mapper;

        public GetRequestsListQueryHandler(IRequestService requestService, IMapper mapper)
        {
            _requestService = requestService;
            _mapper = mapper;
        }

        public async Task<List<Request>> Handle(GetRequestsListQuery request, CancellationToken cancellationToken)
        {
          
            int page = 1; 
            int pageSize = 10; 

            List<Request> requests = await _requestService.GetPagedRequestsAsync(page, pageSize);
            return requests;
        }
    }
}
