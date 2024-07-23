using Application.IRepository;
using Domain.Entities;
using Infrastructure.Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Repositories
{
    public class TraineeRepository : GenericRepository<Trainee>, ITraineeRepository
    {
        private readonly ApplicationDbContext _context;

        public TraineeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Trainee>> GetAllAsNoTracking()
        {
            return await dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<Trainee> GetByIdAsync(Guid id)
        {
            return await _context.Trainees.FirstOrDefaultAsync(r => r.Id == id);
        }
    }
}
