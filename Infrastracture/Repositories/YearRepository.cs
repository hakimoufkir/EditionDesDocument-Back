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
    internal class YearRepository : GenericRepository<Year>, IYearRepository
    {
        private readonly ApplicationDbContext _context;

        public YearRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        //public async Task<List<Year>> GetAllAsNoTracking()
        //{
        //    return await _context.Years.AsNoTracking().ToListAsync();
        //}

        //public async Task<Year> CreateAsync(Year year)
        //{
        //    await _context.Years.AddAsync(year);
        //    await _context.SaveChangesAsync();
        //    return year;
        //}
    }
}
