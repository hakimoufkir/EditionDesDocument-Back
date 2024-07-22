using Application.Features.FilesFeature.Queries.GetAllFiles;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.DocumentFeature.Queries.GetDocumentById
{
    public class GetDocumentByIdQueryHandler : IRequestHandler<GetDocumentByIdQuery, Document>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;


        public GetDocumentByIdQueryHandler(IUnitOfService unitOfService, IMapper mapper)
        {
            _unitOfService = unitOfService;
            _mapper = mapper;

        }

        public async Task<Document> Handle(GetDocumentByIdQuery request, CancellationToken cancellationToken)
        {
            Document result = await _unitOfService.DocumentService.GetDocumentByIdAsync(request.IdDocument);
            return result;
        }
    }
}
