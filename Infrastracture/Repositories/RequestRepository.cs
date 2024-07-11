using Application.IRepository;
using Domain.Entities;
using Infrastructure.Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastracture.Repositories
{
    internal class RequestRepository : GenericRepository<Request>, IRequestRepository
    {
        private readonly ApplicationDbContext _context;

        public RequestRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public Task<List<Request>> GetAllAsNoTracking()
        {
            throw new NotImplementedException();
        }

        public async Task<Request> GetByIdAsync(Guid id)
        {
            return await _context.Requests.FirstOrDefaultAsync(r => r.Id == id);
        }
    }
}
