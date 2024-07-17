using Application.IRepository;
using Domain.Entities;
using Infrastructure.Infrastructure.Data;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Repositories
{
    public class DocumentRepository : GenericRepository<Document>, IDocumentRepository
    {
        public DocumentRepository(ApplicationDbContext db) : base(db)
        {

        }

        public async Task<Document> GetDocumentByIdAsync(Guid id)
        {
            return await GetDocumentByIdAsync(id); // Assuming GetByIdAsync is implemented in GenericRepository
        }

        public async Task<List<Document>> GetAllDocumentsAsync()
        {
            return await GetAllAsNoTracking(); // Assuming GetAllAsync is implemented in GenericRepository
        }

        public async Task AddDocumentAsync(Document document)
        {
            await CreateAsync(document); // Assuming AddAsync is implemented in GenericRepository
        }

        public async Task UpdateDocumentAsync(Document document)
        {
            await UpdateAsync(document); // Assuming UpdateAsync is implemented in GenericRepository
        }

        public async Task DeleteDocumentAsync(Document document)
        {
            await RemoveAsync(document); // Assuming DeleteAsync is implemented in GenericRepository
        }
    }
}
