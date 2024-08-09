using Application.Interfaces;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.PaymentFeature.Queries.GetAllPaymentQuery
{
    public class GetAllPaymentsListQueryHandler : IRequestHandler<GetAllPaymentsListQuery, List<Payment>>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;

        public GetAllPaymentsListQueryHandler(IUnitOfService unitOfService, IMapper mapper)
        {
            _unitOfService = unitOfService;
            _mapper = mapper;
        }
        public async Task<List<Payment>> Handle(GetAllPaymentsListQuery request, CancellationToken cancellationToken)
        {
            List<Payment> payments = await _unitOfService.PaymentService.GetPaymentsList();
            return payments;
        }
    }
}
