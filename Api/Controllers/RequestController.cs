using Application.Features.RequestFeature.Commands.AddRequest;
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

        [HttpPost("/Requests/list")]
        public async Task<IActionResult> AddRequestsList([FromBody] AddRequestCommand addRequestCommand)
        {
            var res = await _mediator.Send(addRequestCommand);
            return Ok(res);
        }
    }
}
