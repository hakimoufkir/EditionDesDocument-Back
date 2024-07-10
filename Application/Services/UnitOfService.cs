using AutoMapper;
using Application.Interfaces;
using Application.IUOW;

namespace Application.Services
{
    public class UnitOfService : IUnitOfService
    {
        #region Props
        private readonly IUnitOfWork _uow;
        public IMapper Mapper { get; set; }
        public IRequestService RequestService { get; set; }
        #endregion



        #region Constructor
        public UnitOfService(IUnitOfWork uow, IMapper map, IRequestService requestService)
        {
            _uow = uow;
            Mapper = map;
            RequestService = requestService;
        }
        #endregion


    }
}
