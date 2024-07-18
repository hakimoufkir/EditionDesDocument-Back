using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.DocumentsFeature.Queries.GetFileByUrlQuery
{
    public class GetFileByUrlQuery : IRequest<GetFileByUrlResponse>
    {
        public string Url { get; set; }
    }
    public class GetFileByUrlResponse
    {
        public byte[] FileContent { get; set; }
        public string ContentType { get; set; }
        public string FileName { get; set; }
    }

}
