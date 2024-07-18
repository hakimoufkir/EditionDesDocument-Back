using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.DocumentsFeature.Commands.UpdateFile
{
    public class UploadFileCommand : IRequest<string>
    {
        public IFormFile File { get; set; }
    }
}
