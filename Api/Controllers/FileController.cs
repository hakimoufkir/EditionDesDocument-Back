using Application.Features.DocumentsFeature.Commands.AddFile;
using Application.Features.DocumentsFeature.Queries;
using Application.Features.DocumentsFeature.Queries.GetFileByUrlQuery;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FileController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("File is required.");

      
            var fileUrl = await _mediator.Send(new UploadFileCommand { File = file });
            return Ok(new { FileUrl = fileUrl });
        }


        [HttpGet("download")]
        public async Task<IActionResult> DownloadFile(string url)
        {
            try
            {
                var response = await _mediator.Send(new GetFileByUrlQuery { Url = url });

                if (response == null)
                {
                    return NotFound();
                }

                var contentType = response.ContentType;
                var fileName = response.FileName;
                var fileStream = new MemoryStream(response.FileContent);

                return File(fileStream, contentType, fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error downloading file: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }

   
}

