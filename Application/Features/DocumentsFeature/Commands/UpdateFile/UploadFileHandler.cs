using Application.IServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.DocumentsFeature.Commands.UpdateFile
{
    public class UploadFileHandler : IRequestHandler<UploadFileCommand, string>
    {
        private readonly IFileManagementService _fileManagementService;

        public UploadFileHandler(IFileManagementService fileManagementService)
        {
            _fileManagementService = fileManagementService;
        }

        public async Task<string> Handle(UploadFileCommand request, CancellationToken cancellationToken)
        {
            return await _fileManagementService.Upload(request.File);
        }
    }
}
