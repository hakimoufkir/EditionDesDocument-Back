using Application.Features.DocumentFeature.Queries.GetDocumentById;
using Application.Interfaces;
using AutoMapper;
using Azure;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.DocumentFeature.Queries.GetAllDocuments
{
    public class GetAllDocumentsListQueryHandler : IRequestHandler<GetAllDocumentsListQuery, List<Document>>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;

        public GetAllDocumentsListQueryHandler(IUnitOfService unitOfService, IMapper mapper)
        {
            _unitOfService = unitOfService;
            _mapper = mapper;
        }

        public async Task<List<Document>> Handle(GetAllDocumentsListQuery request, CancellationToken cancellationToken)
        {
            List<Document> documents = await _unitOfService.DocumentService.GetDocumentsList();
            return documents;
        }
    }
}
