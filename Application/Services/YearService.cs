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

        public async Task<Year> UpdateYearAsync(Year year)
        {
            // Retrieve existing year from the repository
            var existingYear = await _unitOfWork.YearRepository.GetAsNoTracking(y => y.Id == year.Id);
            if (existingYear == null)
            {
                throw new KeyNotFoundException("Year not found");
            }

            // Update the existing year with the new values
            _mapper.Map(year, existingYear);

            // Save changes
            await _unitOfWork.YearRepository.UpdateAsync(existingYear);
            await _unitOfWork.CommitAsync();

            return existingYear;
        }

        public async Task DeleteYearAsync(Guid yearId)
        {
            // Retrieve the year to be deleted
            var year = await _unitOfWork.YearRepository.GetAsNoTracking(y => y.Id == yearId);
            if (year == null)
            {
                throw new KeyNotFoundException("Year not found");
            }

            // Remove the year
            await _unitOfWork.YearRepository.RemoveAsync(year);
            await _unitOfWork.CommitAsync();
        }

    }
}
