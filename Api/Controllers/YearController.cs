using Application.Features.YearFeature.Command.AddYear;
using Application.Features.YearFeature.Command.UpdateYear;
using Application.Features.YearFeature.Commands.DeleteYear;
using Application.Features.YearFeature.Queries.GetYearsList;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
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

        [HttpGet("list")]
        public async Task<ActionResult<List<Year>>> GetAllYears()
        {
            var query = new GetYearsListQuery();
            var years = await _mediator.Send(query);
            return Ok(years);
        }

        [HttpPost("add")]
        public async Task<ActionResult<Year>> CreateYear([FromBody] Year year)
        {
            try
            {
                if (year == null)
                {
                    return BadRequest("Year cannot be null.");
                }

                Year createdYear = await _mediator.Send(new AddYearCommand(year));
                return Ok("Year added successfully!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while adding the year. Details: {ex.Message}");
            }
        }

        [HttpPut("update")]
        public async Task<ActionResult<string>> UpdateYear([FromBody] Year year)
        {
            try
            {
                if (year == null)
                {
                    return BadRequest("Year cannot be null.");
                }

                string result = await _mediator.Send(new UpdateYearCommand(year));
                return Ok(result);
            }
            catch (Exception ex)    
            {
                return StatusCode(500, $"An error occurred while updating the year. Details: {ex.Message}");
            }
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<string>> DeleteYear(Guid id)
        {
            try
            {
                string result = await _mediator.Send(new DeleteYearCommand(id));
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while deleting the year. Details: {ex.Message}");
            }
        }
    }
}
