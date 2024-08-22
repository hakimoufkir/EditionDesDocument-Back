using Application.Broker.Producer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Domain.Entities;
using System.Collections.Generic;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KafkaController : ControllerBase
    {
        private readonly ListTraineeProducer _listTraineeProducer;

        public KafkaController(ListTraineeProducer listTraineeProducer)
        {
            _listTraineeProducer = listTraineeProducer;
        }

        // 1. Endpoint to Request the Trainee List
        [HttpPost("RequestListTrainee")]
        public async Task<IActionResult> RequestListTrainee()
        {
            try
            {
                // Indicate that a request is in progress
                StaticTraineeRequestStatus.SetRequestInProgress();

                // Produce the request to Kafka
                await _listTraineeProducer.ProduceAsync("InscriptionServiceRequestMiddleWare", "ListTrainees");

                return Ok("Trainee list request has been sent.");
            }
            catch (Exception ex)
            {
                // Reset the request status if an error occurs
                StaticTraineeRequestStatus.SetRequestCompleted();
                return StatusCode(500, $"Error requesting trainee list: {ex.Message}");
            }
        }

        // 2. Endpoint to Retrieve the Trainee List
        [HttpGet("RetrieveListTrainee")]
        public IActionResult RetrieveListTrainee()
        {
            try
            {
                // Check if the request is still in progress
                if (StaticTraineeRequestStatus.IsRequestInProgress())
                {
                    return Accepted("Trainee list request is still in progress. Please try again later.");
                }

                // Retrieve the list of trainees
                var traineeList = StaticTrainee.GetTraineeList();

                if (traineeList == null || traineeList.Count == 0)
                {
                    return NotFound("No trainees found.");
                }

                return Ok(traineeList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error retrieving trainee list: {ex.Message}");
            }
        }
    }
}
