using Application.Features.DocumentFeature.Commands.AddDocument;
using Application.Features.DocumentFeature.Commands.UpdateDocument;
using Application.Features.DocumentFeature.Queries.GetAllDocuments;
using Application.Features.DocumentFeature.Queries.GetDocumentById;
using Application.Features.TraineeFeature.Commands.AddTrainee;
using Application.Features.TraineeFeature.Commands.DeleteTrainee;
using Application.Features.TraineeFeature.Commands.UpdateTrainee;
using Application.Features.TraineeFeature.Queries.GetTraineeById;
using Application.Features.TraineeFeature.Queries.GetTraineesList;
using Domain.Dtos;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraineesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TraineesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetTraineesList()
        {
            try
            {
                List<Trainee> OneTrainee = await _mediator.Send(new GetTraineesListQuery());
                return Ok(OneTrainee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpGet("id/{id}")]
        public async Task<IActionResult> GetTraineeById(Guid id)
        {
            try
            {
                Trainee OneTrainee = await _mediator.Send(new GetTraineeByIdQuery(id));
                return Ok(OneTrainee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddTrainee([FromBody] TraineeDto trainee)
        {
            try
            {
                if (trainee == null)
                {
                    return BadRequest("Trainee cannot be null.");
                }

                TraineeDto addedTrainee = await _mediator.Send(new AddTraineeCommand(trainee));
                return Ok("Trainee added successfully!");
            }
            catch (Exception ex)
            {
                
                return StatusCode(500, $"An error occurred while adding the Trainee. Details: {ex.Message}");
            }
        }


        [HttpPut("update")]
        public async Task<IActionResult> UpdateTrainee([FromBody] UpdateTraineeCommand command)
        {
            try
            {
                await _mediator.Send(command);
                return Ok("Trainee Updated Successfully");
            }
            catch (Exception ex)
            {
                // Log the exception details here
                return StatusCode(500, $"An error occurred while updating the Trainee. Details: {ex.Message}");
            }
        }



        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteTrainee(Guid id)
        {
            try
            {
                await _mediator.Send(new DeleteTraineeCommand(id));
                return Ok("Trainee deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while deleting the trainee. Details: {ex.Message}");
            }
        }
    }
}
