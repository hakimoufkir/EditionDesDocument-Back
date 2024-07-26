using Application.Interfaces;
using Application.IServices;
using MediatR;

namespace Application.Features.DocumentsFeature.Queries.GetFileByUrlQuery
{
    public class GetFileByUrlQueryHandler : IRequestHandler<GetFileByUrlQuery, GetFileByUrlResponse>
    {
        private readonly IUnitOfService _unitOfService;

        public GetFileByUrlQueryHandler(IUnitOfService unitOfService)
        {
            _unitOfService = unitOfService;
        }

        public async Task<GetFileByUrlResponse> Handle(GetFileByUrlQuery request, CancellationToken cancellationToken)
        {
            var fileStream = await _unitOfService.FileManagementService.GetFile(request.Url);

            if (fileStream == null)
            {
                return null;
            }

            using (var memoryStream = new MemoryStream())
            {
                await fileStream.CopyToAsync(memoryStream);
                return new GetFileByUrlResponse
                {
                    FileContent = memoryStream.ToArray(),
                    ContentType = "application/octet-stream",
                    FileName = Path.GetFileName(request.Url)
                };
            }
        }
    }
}
