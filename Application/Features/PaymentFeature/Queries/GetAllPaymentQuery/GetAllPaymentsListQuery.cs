using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.PaymentFeature.Queries.GetAllPaymentQuery
{
    public class GetAllPaymentsListQuery : IRequest<List<Payment>>
    {
    }
}
