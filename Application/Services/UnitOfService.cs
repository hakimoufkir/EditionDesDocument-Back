using AutoMapper;
using Application.Interfaces;
using Application.IUnitOfWorks;
using Application.IServices;

namespace Application.Services
{
    public class UnitOfService : IUnitOfService
    {
        #region Props
        public IMapper Mapper { get; set; }
        public IRequestService RequestService { get; set; }
        public IFileManagementService FileManagementService { get; set; }

        public IDocumentService DocumentService { get; set; }



        #endregion

        #region Constructor
        public UnitOfService(IMapper mapper, IRequestService requestService, IFileManagementService fileManagementService, IDocumentService documentService)
        {
            Mapper = mapper;
            RequestService = requestService;
            FileManagementService = fileManagementService;
            DocumentService = documentService;
        }


        #endregion
    }
}
