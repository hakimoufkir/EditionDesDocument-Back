using Application.Features.DocumentFeature.Queries.GetAllDocuments;
using Application.Features.GroupFeature.Commands.AddGroup;
using Application.Features.GroupFeature.Queries.GetAllGroupQuery;
using Application.Features.TraineeFeature.Commands.AddTrainee;
using Domain.Dtos;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GroupsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost("add")]
        public async Task<IActionResult> AddTrainee([FromBody] GroupDto group)
        {
            try
            {
                if (group == null)
                {
                    return BadRequest("group cannot be null.");
                }

                GroupDto addedGroup = await _mediator.Send(new AddGroupCommand(group));
                return Ok("Group added successfully!");
            }
            catch (Exception ex)
            {

                return StatusCode(500, $"An error occurred while adding the Group. Details gg: {ex.Message}");
            }
        }


        [HttpGet("list")]
        public async Task<IActionResult> GetGroupsList()
        {
            try
            {
                List<Group> GroupsList = await _mediator.Send(new GetAllGroupsListQuery());
                return Ok(GroupsList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
