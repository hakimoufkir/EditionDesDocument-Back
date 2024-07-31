using Application.IServices;
using Application.Services;
using Domain.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.PaymentFeature.Commands.AddPayment
{
    public class AddPaymentCommandHandler : IRequestHandler<AddPaymentCommand, PaymentDto>
    {
        public readonly IPaymentService _paymentService;
        public AddPaymentCommandHandler(IPaymentService paymentService)
        {
            _paymentService = paymentService;
            
        }
            
        


        public async Task<PaymentDto> Handle(AddPaymentCommand request, CancellationToken cancellationToken)
        {
            return await _paymentService.AddPaymentAsync(request.PaymentDto);
        }
    }
}
