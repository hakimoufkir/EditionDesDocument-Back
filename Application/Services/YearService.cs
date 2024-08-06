using Application.IRepository;
using Application.IServices;
using Application.IUnitOfWorks;
using AutoMapper;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class YearService : IYearService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public YearService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Year> CreateYearAsync(Year year)
        {
            var years = _mapper.Map<Year>(year);
            await _unitOfWork.YearRepository.CreateAsync(years);
            await _unitOfWork.CommitAsync();
            return years;
        }

        public async Task<List<Year>> GetAllYearsAsync()
        {
            return await _unitOfWork.YearRepository.GetAllAsNoTracking();
        }
    }
}
