using Application.IRepository;
using Application.IServices;
using Application.IUnitOfWorks;
using Domain.Entities;
using Domain.Enums;
using Soenneker.Extensions.Enumerable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DocumentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Document>> GetDocumentsList()
        {
            List<Document> documentsList = await _unitOfWork.DocumentRepository.GetAllAsNoTracking();
            if (documentsList.IsNullOrEmpty())
            {
                throw new ArgumentException("No documents found.");
            }
            return documentsList;
        }

        public async Task<Document> GetDocumentByIdAsync(Guid IdDocument)
        {
            Document document = await _unitOfWork.DocumentRepository.GetAsNoTracking(u => u.Id == IdDocument);
            if (document == null)
            {
                throw new ArgumentException(ResponsStutusHandler.StatusMessages.InternalServerError);
            }
            return document;

        }

        public async Task<Document> GetDocumentByUrlAsync(string documentUrl)
        {
            Document document = await _unitOfWork.DocumentRepository.GetAsNoTracking(u => u.PathFile == documentUrl);
            if (document == null)
            {
                throw new ArgumentException("Document not found.");
            }
            return document;
        }

        public async Task<Document> AddDocumentAsync(Document document)
        {
            if (document == null)
            {
                throw new ArgumentNullException(nameof(document), "Document cannot be null.");
            }
            document.CreatedDate = DateTime.Now;
            document.Id = Guid.NewGuid();
            await _unitOfWork.DocumentRepository.CreateAsync(document);
            await _unitOfWork.CommitAsync();
            return document;
        }

        public async Task DeleteAllDocumentsAsync()
        {
            var documents = await _unitOfWork.DocumentRepository.GetAllAsTracking();
            if (documents == null || documents.Count == 0)
            {
                throw new ArgumentException("No documents found to delete.");
            }

            await _unitOfWork.DocumentRepository.RemoveAllAsync();
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateDocumentAsync(Document document)
        {
            if (document == null)
            {
                throw new ArgumentNullException(nameof(document));
            }

            Document existingDocument = await _unitOfWork.DocumentRepository.GetAsNoTracking(
                d => d.Id == document.Id);
            if (existingDocument == null)
            {
                throw new ArgumentException("Document not found.");
            }

            existingDocument.PathFile = document.PathFile;
            existingDocument.InstantJSON = document.InstantJSON;

            try
            {
                await _unitOfWork.DocumentRepository.UpdateAsync(existingDocument);
                await _unitOfWork.CommitAsync();
            }
            catch (Exception ex)
            {

                throw new ArgumentException($"Exception: {ex.Message}\nStackTrace: {ex.StackTrace}");
            }
        }
    }
}
