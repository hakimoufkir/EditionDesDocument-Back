using Application.Features.DocumentFeature.Queries.GetDocumentById;
using Application.Features.RequestFeature.Commands.AddRequest;
using Application.Features.RequestFeature.Commands.UpdateRequest;
using Application.Features.RequestFeature.Queries.GetRequestByID;
using Application.Features.RequestFeature.Queries.GetRequestsList;
using Domain.Entities;
using Domain.Enums;
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

                if (result.StartsWith(ResponsStutusHandler.Status.Success.ToString()))
                {
                    return Ok(result);
                }
                else if (result.StartsWith(ResponsStutusHandler.Status.BadRequest.ToString()))
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
        public async Task<IActionResult> UpdateRequest([FromBody] UpdateRequestCommand updateRequestCommand)
        {


            try
            {
                string result = await _mediator.Send(updateRequestCommand);

                if (result.StartsWith(ResponsStutusHandler.Status.Success.ToString()))
                {
                    return Ok("Successfully changed the status of request");
                }
                else if (result.StartsWith(ResponsStutusHandler.Status.BadRequest.ToString()))
                {
                    return BadRequest(result);
                }
                else if (result == ResponsStutusHandler.Status.RequestNotFound.ToString())
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


        [HttpGet("{id}")]
        public async Task<IActionResult> GetRequestById(Guid id)
        {
            try
            {
                Request req = await _mediator.Send(new GetRequestByIdQuery(id));
                return Ok(req);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


    }

}