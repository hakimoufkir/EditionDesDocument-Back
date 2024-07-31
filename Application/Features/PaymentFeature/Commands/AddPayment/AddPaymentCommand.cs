using Domain.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.PaymentFeature.Commands.AddPayment
{
    public class AddPaymentCommand : IRequest<PaymentDto>
    {

        public PaymentDto PaymentDto { get; set; }

        public AddPaymentCommand(PaymentDto paymentDto)
        {
            PaymentDto = paymentDto;
        }
        
    }
}
