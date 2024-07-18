//using Application.IServices;
//using Application.IUOW;
//using Domain.Entities;
//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Application.Features.DocumentsFeature.Queries
//{
//    public class GetDocumentQueryHandler : IRequestHandler<GetDocumentQuery, GetDocumentResponse>
//    {
//        private readonly IFileManagementService _fileManagementService;
//        private readonly IUnitOfWork _unitOfWork;

//        public GetDocumentQueryHandler(IFileManagementService fileManagementService, IUnitOfWork unitOfWork)
//        {
//            _fileManagementService = fileManagementService;
//            _unitOfWork = unitOfWork;
//        }

//        public async Task<GetDocumentResponse> Handle(GetDocumentQuery request, CancellationToken cancellationToken)
//        {
//            var document = await _unitOfWork.DocumentRepository.GetAsTracking(d => d.Id == request.DocumentId);

//            if (document == null)
//            {
//                throw new FileNotFoundException("Document not found.");
//            }

//            var fileUrl = document.FilePath;
//            var fileStream = await _fileManagementService.GetFile(fileUrl);

//            using (var memoryStream = new MemoryStream())
//            {
//                await fileStream.CopyToAsync(memoryStream);
//                return new GetDocumentResponse
//                {
//                    FileContent = memoryStream.ToArray(),
//                    ContentType = "application/pdf",
//                    FileName = Path.GetFileName(fileUrl)
//                };
//            }
//        }

//    }
//}
