using Application.Interfaces;
using Application.IServices;
using MediatR;

namespace Application.Features.DocumentsFeature.Commands.AddFile
{
    public class UploadFileCommandHandler : IRequestHandler<UploadFileCommand, string>
    {
    
        private readonly IUnitOfService _uos;

        public UploadFileCommandHandler(IUnitOfService uos)
        {
           
            _uos= uos;
        }

        public async Task<string> Handle(UploadFileCommand request, CancellationToken cancellationToken)
        {
            return await _uos.FileManagementService.Upload(request.File);
        }
    }
}
