using Application.Broker.Producer;
using Application.Interfaces;
using Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KafkaController : ControllerBase
    {
       // private readonly ListTraineeProducer _listTraineeProducer;

        //public KafkaController(ListTraineeProducer listTraineeProducer)
        //{
        //    _listTraineeProducer = listTraineeProducer;
        //}
        private readonly IUnitOfService _unitOfService;

        public KafkaController(IUnitOfService unitOfService)
        {
            _unitOfService = unitOfService;
        }
        [HttpGet("RequestListTrainee")]
        public async Task<IActionResult> PostRequestListTrainee()
        {
            try
            {
             
                return Ok(await _unitOfService.TraineeService.GetListTraineesFormKafkaAsync());
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error listing trainees: {ex.Message}");
            }
        }

        //[HttpGet("RequestListTrainee")]
        //public async Task<IActionResult> PostRequestListTrainee()
        //{
        //    try
        //    {
        //        await _listTraineeProducer.ProduceAsync("InscriptionServiceRequestMiddleWare", "ListTrainees");
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, $"Error listing trainees: {ex.Message}");
        //    }
        //}
    }
}