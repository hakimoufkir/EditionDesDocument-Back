using Application.Features.GroupFeature.Commands.AddGroup;
using Application.Features.GroupFeature.Queries.GetAllGroupQuery;
using Application.Features.PaymentFeature.Commands.AddPayment;
using Application.Features.PaymentFeature.Queries.GetAllPaymentQuery;
using Domain.Dtos;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {

        private readonly IMediator _mediator;

         public PaymentsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost("add")]
        public async Task<IActionResult> AddPayment([FromBody] PaymentDto payment)
        {
            try
            {
                if (payment == null)
                {
                    return BadRequest("payment cannot be null.");
                }

                PaymentDto addedpayment = await _mediator.Send(new AddPaymentCommand(payment));
                return Ok("payment added successfully!");
            }
            catch (Exception ex)
            {

                return StatusCode(500, $"An error occurred while adding the payment. Details : {ex.Message}");
            }
        }


        [HttpGet("list")]
        public async Task<IActionResult> GetPaymentsList()
        {
            try
            {
                List<Payment> PaymentsList = await _mediator.Send(new GetAllPaymentsListQuery());
                return Ok(PaymentsList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
