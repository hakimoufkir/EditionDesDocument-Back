using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IDocumentService
    {
        Task<List<Document>> GetDocumentsList();
        Task<Document> GetDocumentByIdAsync(Guid IdDocument);
        Task<Document> GetDocumentByUrlAsync(string documentUrl);
        Task<Document> AddDocumentAsync(Document document);
        Task DeleteAllDocumentsAsync();
        Task UpdateDocumentAsync(Document document);


    }
}
