using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IYearService
    {
        Task<Year> CreateYearAsync(Year year);
        Task<List<Year>> GetAllYearsAsync();

        Task<Year> UpdateYearAsync(Year year);
        Task DeleteYearAsync(Guid yearId);

    }
}
