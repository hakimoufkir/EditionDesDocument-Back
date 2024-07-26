using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.DocumentFeature.Commands.DeleteDocument
{
    public class DeleteAllDocumentsCommand : IRequest<string>
    {
    }
}
