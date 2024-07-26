using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.DocumentFeature.Commands.AddDocument
{
    public class AddDocumentCommand : IRequest<Document>
    {
        public Document Document { get; set; }

        public AddDocumentCommand(Document document)
        {
            Document = document;
        }
    }
}
