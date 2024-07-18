//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Application.Features.DocumentsFeature.Queries
//{
//    public class GetDocumentQuery : IRequest<GetDocumentResponse>
//    {
//        public Guid DocumentId { get; set; }
//    }

//    public class GetDocumentResponse
//    {
//        public Guid Id { get; set; }
//        public Guid IdModelDocuments { get; set; }
//        public string DocumentType { get; set; }
//        public string FilePath { get; set; }
//        public string? CreatedBy { get; set; }
//        public DateTime CreatedDate { get; set; }
//        public string? LastModifiedBy { get; set; }
//        public DateTime? LastModifiedDate { get; set; }
//        public byte[] FileContent { get; set; } 
//        public string ContentType { get; set; } 
//        public string FileName { get; set; }
//    }
//}
