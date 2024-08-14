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
        public string PathFile { get; set; }
        public string? InstantJSON { get; set; }
        public string? Name { get; set; }
    }
}
