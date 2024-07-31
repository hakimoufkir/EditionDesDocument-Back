using Application.Features.YearFeature.Command.AddYear;
using Application.Features.YearFeature.Queries.GetYearsList;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YearController : ControllerBase
    {
        private readonly IMediator _mediator;

        public YearController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("/Year/list")]
        public async Task<ActionResult<List<Year>>> GetAllYears()
        {
            var query = new GetYearsListQuery();
            var years = await _mediator.Send(query);
            return Ok(years);
        }

        [HttpPost("/Year/Add")]
        public async Task<ActionResult<Year>> CreateYear([FromBody] Year year)
        {
            
            Year createdYear = await _mediator.Send(new AddYearCommand(year));
            return Ok("added successfully");
        }

        
    }
}
