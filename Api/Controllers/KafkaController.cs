using Application.Broker.Producer;
using Application.Features.FilesFeature.Queries.GetAllFiles;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KafkaController : ControllerBase
    {
        private readonly KafkaRequester _kafkaRequester;


        public KafkaController(KafkaRequester kafkaRequester)
        {
            _kafkaRequester = kafkaRequester;
        }

        [HttpGet("RequestListTrainee")]
        public async Task<IActionResult> PostRequestListTrainee()
        {
            try
            {
                await _kafkaRequester.ProduceAsync("InscriptionServiceRequestMiddleWare", "ListTrainees");
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error listing files: {ex.Message}");
            }
        }
    }
}
