using AutoMapper;
using Application.Interfaces;
using Application.IUnitOfWorks;
using Application.IServices;

namespace Application.Services
{
    public class UnitOfService : IUnitOfService
    {
        #region Props
        private readonly IUnitOfWork _unitOfService;
        public IMapper Mapper { get; set; }
        public IRequestService RequestService { get; set; }
        public ICheckRoleService CheckRoleService { get; set; }
        public IFileManagementService FileManagementService { get; set; }
        #endregion

        #region Constructor
        public UnitOfService(IUnitOfWork unitOfService, IMapper map, IRequestService requestService, ICheckRoleService checkRoleService, IFileManagementService fileManagementService)
        {
            _unitOfService = unitOfService;
            Mapper = map;
            RequestService = requestService;
            CheckRoleService = checkRoleService;
            FileManagementService = fileManagementService;
        }
        #endregion
    }
}
