using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepository
{
    public interface IYearRepository : IGenericRepository<Year>
    {
        //Task CreateAsync(Year year);
        //Task<List<Year>> GetAllAsNoTracking();
    }
}
