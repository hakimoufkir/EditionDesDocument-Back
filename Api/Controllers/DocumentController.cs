using Application.Features.DocumentFeature.Commands.AddDocument;
using Application.Features.DocumentFeature.Commands.DeleteDocument;
using Application.Features.DocumentFeature.Commands.UpdateDocument;
using Application.Features.DocumentFeature.Queries.GetAllDocuments;
using Application.Features.DocumentFeature.Queries.GetDocumentById;
using Application.Features.DocumentFeature.Queries.GetDocumentByUrl;
using Application.Features.FilesFeature.Queries.GetAllFiles;
using Application.Features.TraineeFeature.Queries.GetTraineeById;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DocumentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetDocumentsList()
        {
            try
            {
                List<Document> DocumentsList = await _mediator.Send(new GetAllDocumentsListQuery());
                return Ok(DocumentsList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDocumentById(Guid id)
        {
            try
            {
                Document OneDocument = await _mediator.Send(new GetDocumentByIdQuery(id));
                return Ok(OneDocument);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("getDocumentByURL")]
        public async Task<IActionResult> GetDocumentByUrl([FromBody] string DocumentUrl)
        {
            try
            {
                var getDocumentByUrlQuery = new GetDocumentByUrlQuery(DocumentUrl);
                Document document = await _mediator.Send(getDocumentByUrlQuery);
                return Ok(document);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                // Log exception here
                return StatusCode(500, "An internal server error occurred.");
            }
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddDocument([FromBody] AddDocumentCommand addDocumentCommand)
        {
            try
            {
                if (addDocumentCommand == null)
                {
                    return BadRequest("Document cannot be null.");
                }

                Document addedDocument = await _mediator.Send(addDocumentCommand);
                return Ok(addedDocument);
            }
            catch (Exception ex)
            {
                // Log exception details here
                return StatusCode(500, $"An error occurred while adding the document. Details: {ex.Message}");
            }
        }

        [HttpDelete("deleteAll")]
        public async Task<IActionResult> DeleteAllDocuments()
        {
            try
            {
                await _mediator.Send(new DeleteAllDocumentsCommand());
                return NoContent();
            }
            catch (Exception ex)
            {
                // Log exception details here
                return StatusCode(500, $"An error occurred while deleting documents. Details: {ex.Message}");
            }
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateDocument([FromBody] UpdateDocumentCommand command)
        {
            try
            {
                await _mediator.Send(command);
                return Ok("Document Updated Successfully");
            }
            catch (Exception ex)
            {
                // Log the exception details here
                return StatusCode(500, $"An error occurred while updating the document. Details: {ex.Message}");
            }
        }

        [HttpPost("print")]
        public async Task<IActionResult> PrintDocument(
            [FromBody] string request
            /*[FromBody] PrintDocumentRequest request*/
            )
        {
            /* try
             {
                 // Fetch the trainee data
                 var trainee = await _mediator.Send(new GetTraineeByIdQuery(request.IdTrainee));

                 // Fetch the document data
                 var document = await _mediator.Send(new GetDocumentByIdQuery(request.DocumentId));

                 if (trainee == null || document == null)
                 {
                     return NotFound("Trainee or Document not found.");
                 }

                 // Update InstantJSON with trainee data
                 var instantJSON = JsonConvert.DeserializeObject<InstantJSON>(document.InstantJSON);
                 var field = instantJSON.FormFieldValues.FirstOrDefault(f => f.Name == "Trainee_FirstName");

                 if (field != null)
                 {
                     field.Value = trainee.FirstName; // Update with the actual value
                 }

                 var updatedInstantJSON = JsonConvert.SerializeObject(instantJSON);

                 // Update document with the new InstantJSON
                 await _mediator.Send(new UpdateDocumentCommand(document.Id, updatedInstantJSON));

                 return Ok("Document updated successfully.");
             }
             catch (Exception ex)
             {
                 return StatusCode(500, $"An error occurred: {ex.Message}");
             }*/
            return Ok("testing ...");
        }


    }
}
