using Application.Features.DocumentFeature.Queries.GetDocumentById;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.DocumentFeature.Queries.GetDocumentByUrl
{
    public class GetDocumentByUrlQueryHandler : IRequestHandler<GetDocumentByUrlQuery, Document>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;

        public GetDocumentByUrlQueryHandler(IUnitOfService unitOfService, IMapper mapper)
        {
            _unitOfService = unitOfService;
            _mapper = mapper;
        }

        public async Task<Document> Handle(GetDocumentByUrlQuery request, CancellationToken cancellationToken)
        {
            Document result = await _unitOfService.DocumentService.GetDocumentByUrlAsync(request.DocumentUrl);
            return result;
        }
    }
}
