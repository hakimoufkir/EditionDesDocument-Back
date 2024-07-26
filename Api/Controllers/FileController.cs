using Application.Features.DocumentFeature.Commands.DeleteDocument;
using Application.Features.DocumentsFeature.Commands.AddFile;
using Application.Features.DocumentsFeature.Queries;
using Application.Features.DocumentsFeature.Queries.GetFileByUrlQuery;
using Application.Features.FilesFeature.Queries.GetAllFiles;
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
            if (string.IsNullOrWhiteSpace(url))
            {
                return BadRequest("The file URL is required.");
            }

            try
            {
                // Decode the URL if needed
                string decodedUrl = Uri.UnescapeDataString(url);


                var response = await _mediator.Send(new GetFileByUrlQuery { Url = decodedUrl });

                if (response == null)
                {
                    return NotFound();
                }

                if (response.FileContent == null || response.FileContent.Length == 0)
                {
                    return NotFound("File content is empty.");
                }

                var contentType = response.ContentType ?? "application/octet-stream";
                var fileName = response.FileName ?? "unknown";

             

                var fileStream = new MemoryStream(response.FileContent);
                return File(fileStream, contentType, fileName);
            }
            catch (Exception ex)
            {
                // Log the exception details
                return StatusCode(500, "Internal server error");
            }
        }


        [HttpGet("list")]
        public async Task<IActionResult> ListFiles()
        {
            try
            {
                var files = await _mediator.Send(new GetAllFilesQuery());
                return Ok(files);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error listing files: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }


        
    }

   
}

