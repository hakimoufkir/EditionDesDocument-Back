//using Application.IRepository;
//using Domain.Entities;
//using Infrastructure.Infrastructure.Data;
//using Infrastructure.Repositories;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Infrastracture.Repositories
//{
//    public class DocumentRepository : GenericRepository<Document>, IDocumentRepository
//    {
//        public DocumentRepository(ApplicationDbContext db) : base(db)
//        {

//        }

//        public async Task<Document> GetDocumentByIdAsync(Guid id)
//        {
//            return await GetDocumentByIdAsync(id); 
//        }

//        public async Task<List<Document>> GetAllDocumentsAsync()
//        {
//            return await GetAllAsNoTracking(); 
//        }

//        public async Task AddDocumentAsync(Document document)
//        {
//            await CreateAsync(document); 
//        }

//        public async Task UpdateDocumentAsync(Document document)
//        {
//            await UpdateAsync(document); 
//        }

//        public async Task DeleteDocumentAsync(Document document)
//        {
//            await RemoveAsync(document);
//        }
//    }
//}
