using Application.IServices;
using Application.IUnitOfWorks;
using AutoMapper;
using Domain.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Application.Services
{
    public class GroupService : IGroupService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GroupService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<GroupDto> AddGroupAsync(GroupDto group)
        {
            if (group == null)
            {
                throw new ArgumentNullException(nameof(group), "group cannot be null.");
            }

            var groups = _mapper.Map<Group>(group);
            await _unitOfWork.GroupRepository.CreateAsync(groups);
            await _unitOfWork.CommitAsync();
            return _mapper.Map<GroupDto>(groups);

        }

    


    }
}
