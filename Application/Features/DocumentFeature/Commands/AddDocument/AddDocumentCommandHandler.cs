using Application.Interfaces;
using Application.IServices;
using AutoMapper;
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
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;

        public AddDocumentCommandHandler(IUnitOfService unitOfService, IMapper mapper)
        {
            _unitOfService = unitOfService;
            _mapper = mapper;
        }




        public async Task<Document> Handle(AddDocumentCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request), "Document cannot be null.");
            }

            if (request.PathFile == null)
            {
                throw new ArgumentNullException(nameof(request.PathFile), "PathFile cannot be null.");

            }
            Document documentMapped = _mapper.Map<Document>(request);
            Document addedDocument = await _unitOfService.DocumentService.AddDocumentAsync(documentMapped);
            return addedDocument;
        }
    }
}
