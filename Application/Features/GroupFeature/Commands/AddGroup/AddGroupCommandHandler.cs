using Application.IServices;
using Application.Services;
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
    public class AddGroupCommandHandler : IRequestHandler<AddGroupCommand, GroupDto>
    {
        private readonly IGroupService _groupService;


        public AddGroupCommandHandler(IGroupService groupService)
        {
            _groupService = groupService ?? throw new ArgumentNullException(nameof(groupService));
        }

        public async Task<GroupDto> Handle(AddGroupCommand request, CancellationToken cancellationToken)
        {
           try
            {
                if (request.Group == null)
                {
                    throw new ArgumentNullException(nameof(request.Group), "Group cannot be null.");
                }
                return await _groupService.AddGroupAsync(request.Group);
            }
            catch(Exception ex)
            {
                throw new ApplicationException($"An error occurred while adding the Group. Details !!♥: {ex.Message} {ex.StackTrace}", ex);
            }
        }
    }
}
