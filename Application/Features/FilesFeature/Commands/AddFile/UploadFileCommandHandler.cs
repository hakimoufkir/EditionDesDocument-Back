using Application.Interfaces;
using Application.IServices;
using MediatR;

namespace Application.Features.DocumentsFeature.Commands.AddFile
{
    public class UploadFileCommandHandler : IRequestHandler<UploadFileCommand, string>
    {
    
        private readonly IUnitOfService _unitOfService;

        public UploadFileCommandHandler(IUnitOfService unitOfService)
        {

            _unitOfService = unitOfService;
        }

        public async Task<string> Handle(UploadFileCommand request, CancellationToken cancellationToken)
        {
            return await _unitOfService.FileManagementService.Upload(request.File);
        }
    }
}
