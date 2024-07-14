using Application.Features.RequestFeature.Commands.AddRequest;
using Application.Features.RequestFeature.Commands.UpdateRequest;
using Application.Features.RequestFeature.Queries.GetRequestsList;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RequestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("/Requests/list")]
        public async Task<IActionResult> GetRequestsList()
        {
            var res = await _mediator.Send(new GetRequestsListQuery());
            return Ok(res);
        }

        [HttpPost("/Requests/add")]
        public async Task<IActionResult> AddRequestsList([FromBody] AddRequestCommand addRequestCommand)
        {
            try
            {
                string result = await _mediator.Send(addRequestCommand);

                if (result.StartsWith("Success"))
                {
                    return Ok(result);
                }
                else if (result.StartsWith("BadRequest"))
                {
                    return BadRequest(result);
                }
                else
                {
                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }


        [HttpPut("/Requests/update")]
        public async Task<IActionResult> UpdateRequest( [FromBody] UpdateRequestCommand updateRequestCommand)
        {
         

            try
            {
                string result = await _mediator.Send(updateRequestCommand);

                if (result.StartsWith("Success"))
                {
                    return Ok("Successfully changed the status of request");
                }
                else if (result.StartsWith("BadRequest"))
                {
                    return BadRequest(result);
                }
                else if (result == "Request not found")
                {
                    return NotFound(result);
                }
                else
                {
                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }





    }
    
}
