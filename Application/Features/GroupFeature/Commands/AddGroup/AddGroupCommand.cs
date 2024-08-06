using Domain.Dtos;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Application.Features.GroupFeature.Commands.AddGroup
{
    public class AddGroupCommand : IRequest<GroupDto>
    {
        public GroupDto Group { get; set;}

        public AddGroupCommand(GroupDto group)
        {
            Group = group;
        }

    }
}
