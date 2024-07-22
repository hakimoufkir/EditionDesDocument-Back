using Application.Features.DocumentFeature.Commands.AddDocument;
using Application.Features.DocumentFeature.Commands.DeleteDocument;
using Application.Features.DocumentFeature.Commands.UpdateDocument;
using Application.Features.DocumentFeature.Queries.GetAllDocuments;
using Application.Features.DocumentFeature.Queries.GetDocumentById;
using Application.Features.DocumentFeature.Queries.GetDocumentByUrl;
using Application.Features.FilesFeature.Queries.GetAllFiles;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

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
                List<Document> OneDocument = await _mediator.Send(new GetAllDocumentsListQuery());
                return Ok(OneDocument);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("id/{id}")]
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
        public async Task<IActionResult> AddDocument([FromBody] Document document)
        {
            try
            {
                if (document == null)
                {
                    return BadRequest("Document cannot be null.");
                }

                Document addedDocument = await _mediator.Send(new AddDocumentCommand(document));
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


    }
}
