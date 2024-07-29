using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Application.Features.GroupFeature.Queries.GetAllGroupQuery
{
    public class GetAllGroupsListQueryHandler : IRequestHandler<GetAllGroupsListQuery, List<Group>>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;

        public GetAllGroupsListQueryHandler(IUnitOfService unitOfService, IMapper mapper)
        {
            _unitOfService = unitOfService;
            _mapper = mapper;
        }
        public async Task<List<Group>> Handle(GetAllGroupsListQuery request, CancellationToken cancellationToken)
        {
            List<Group> groups = await _unitOfService.GroupService.GetGroupsList();
            return groups;
        }
    }
}
