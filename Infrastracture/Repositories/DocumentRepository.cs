using Application.IRepository;
using Domain.Entities;
using Infrastructure.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class DocumentRepository : GenericRepository<Document>, IDocumentRepository
    {
        private readonly ApplicationDbContext _context;

        public DocumentRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task RemoveAllAsync()
        {
            var documents = await dbSet.ToListAsync(); // Use dbSet from GenericRepository
            if (documents.Count > 0)
            {
                dbSet.RemoveRange(documents);
                await _context.SaveChangesAsync();
            }
        }
    }
}
