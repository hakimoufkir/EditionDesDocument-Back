using Domain.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IGroupService
    {
        Task<GroupDto> AddGroupAsync(GroupDto group);
    }
}

