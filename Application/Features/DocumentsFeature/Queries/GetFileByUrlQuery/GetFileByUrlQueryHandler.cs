using Application.IServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.DocumentsFeature.Queries.GetFileByUrlQuery
{
    public class GetFileByUrlQueryHandler : IRequestHandler<GetFileByUrlQuery, GetFileByUrlResponse>
    {
        private readonly IFileManagementService _fileManagementService;

        public GetFileByUrlQueryHandler(IFileManagementService fileManagementService)
        {
            _fileManagementService = fileManagementService;
        }

        public async Task<GetFileByUrlResponse> Handle(GetFileByUrlQuery request, CancellationToken cancellationToken)
        {
            var fileStream = await _fileManagementService.GetFile(request.Url);

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
