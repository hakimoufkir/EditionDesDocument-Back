using Application.Interfaces;
using Application.IServices;
using Application.IUOW;
using Domain.Entities;
using MediatR;

namespace Application.Services;

public class RequestService : IRequestService
{
    #region Props
    private readonly IUnitOfWork _uow;
    private readonly ICheckRoleService _checkRoleService;
    #endregion     
    #region Constructor
    public RequestService(IUnitOfWork uow, ICheckRoleService checkRoleService)
    {
        _uow = uow;
        _checkRoleService = checkRoleService;
    }
    #endregion
    #region Methods
    public async Task<List<Request>> GetRequestsListAsync()
    {
        List<Request> requestsList = await _uow.RequestRepository.GetAllAsNoTracking();
        return requestsList;

    }

    public Task<Request> GetRequestByIdAsync(Guid IdRequest)
    {
        throw new NotImplementedException();
    }

    public async Task<string> AddRequestAsync(Request Request)
    {
        if (await _checkRoleService.CheckRole(Request))
        {
            return "BadRequest: Role cannot be 'assistante'";
        }

        try
        {
            await _uow.RequestRepository.CreateAsync(Request);
            await _uow.CommitAsync();
            return "Success";
        }
        catch (Exception ex)
        {

            throw new Exception("Error adding request: " + ex.Message);
        }

    }
    #endregion

}