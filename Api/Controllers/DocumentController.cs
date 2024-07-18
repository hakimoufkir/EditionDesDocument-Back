using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Application.Services;
using Application.IServices; 

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FileController : ControllerBase
    {
        private readonly IFileManagementService _fileManagement;

        public FileController(IFileManagementService fileManagement)
        {
            _fileManagement = fileManagement;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("File is required.");

            var fileUrl = await _fileManagement.Upload(file);
            return Ok(new { FileUrl = fileUrl });
        }
        [HttpGet("download")]
        public async Task<IActionResult> DownloadFile(string url)
        {
            try
            {
                // Call your service method to get the file as a Stream
                var fileStream = await _fileManagement.GetFile(url);

                // Check if fileStream is null or empty
                if (fileStream == null)
                {
                    return NotFound(); // Or handle appropriately if file doesn't exist
                }

                // Set content type based on file type
                var contentType = "application/octet-stream"; // Example content type for a binary file
                var fileName = "downloadedFile.bin"; // Example file name

                // Return the file as FileStreamResult
                return File(fileStream, contentType, fileName);
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error downloading file: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
        
    }
}
