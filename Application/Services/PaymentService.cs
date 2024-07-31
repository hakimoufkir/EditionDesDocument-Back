using Application.IServices;
using Application.IUnitOfWorks;
using AutoMapper;
using Domain.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public PaymentService(IMapper mapper , IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        
        public async Task<PaymentDto> AddPaymentAsync(PaymentDto paymentDto)
        {
            var payment = _mapper.Map<Payment>(paymentDto);
            await _unitOfWork.PaymentRepository.CreateAsync(payment);
            await _unitOfWork.CommitAsync();
            return _mapper.Map<PaymentDto>(payment);
        }

        public async Task<List<Payment>> GetPaymentsList()
        {
            List<Payment> paymentsList = await _unitOfWork.PaymentRepository.GetAllAsNoTracking();
            return paymentsList;
        }
    }
}
