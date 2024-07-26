using Application.IServices;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.DocumentFeature.Commands.AddDocument
{
    public class AddDocumentCommandHandler : IRequestHandler<AddDocumentCommand, Document>
    {
        private readonly IDocumentService _documentService;

        public AddDocumentCommandHandler(IDocumentService documentService)
        {
            _documentService = documentService ?? throw new ArgumentNullException(nameof(documentService));
        }

        public async Task<Document> Handle(AddDocumentCommand request, CancellationToken cancellationToken)
        {
            try
            {
                if (request.Document == null)
                {
                    throw new ArgumentNullException(nameof(request.Document), "Document cannot be null.");
                }

                Document addedDocument = await _documentService.AddDocumentAsync(request.Document);
                return addedDocument;
            }
            catch (Exception ex)
            {
                // Log the exception details
                throw new ApplicationException($"An error occurred while adding the document. Details: {ex.Message} {ex.StackTrace}", ex);
            }
        }
    }
}
