using Domain.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepository
{
    public interface ITraineeRepository : IGenericRepository<Trainee>
    {
        Task<Trainee> GetByIdAsync(Guid id);
        Task UpdateAsync(Trainee trainee);
        Task CreateAsync(Trainee trainee);

        //Task<List<Trainee>> GetAllAsNoTracking();
    }
}
