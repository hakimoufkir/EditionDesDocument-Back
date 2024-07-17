using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.DocumentsFeature.Queries
{
    public class DownloadDocumentQuery : IRequest<DownloadDocumentResponse>
    {
        public Guid DocumentId { get; set; }
    }

    public class DownloadDocumentResponse
    {
        public byte[] FileContent { get; set; }
        public string ContentType { get; set; }
        public string FileName { get; set; }
    }
}
