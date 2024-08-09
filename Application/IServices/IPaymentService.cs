﻿using Domain.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IPaymentService
    {

        Task<List<Payment>> GetPaymentsList();

        Task<PaymentDto> AddPaymentAsync(PaymentDto paymentDto);
    }
}
