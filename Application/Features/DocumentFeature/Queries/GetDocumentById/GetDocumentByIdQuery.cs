using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.DocumentFeature.Queries.GetDocumentById
{
    public class GetDocumentByIdQuery : IRequest<Document>
    {
        public Guid IdDocument { get; set; }

        public GetDocumentByIdQuery(Guid idDocument)
        {
            IdDocument = idDocument;
        }
    }
}
