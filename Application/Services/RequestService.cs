using Application.Interfaces;
using Application.IUOW;
using Domain.Entities;

namespace Application.Services;

public class RequestService : IRequestService
{
    #region Props
    private readonly IUnitOfWork _uow;
    #endregion     
    #region Constructor
    public RequestService(IUnitOfWork uow)
    {
        _uow = uow;
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
        try
        {
            await _uow.RequestRepository.CreateAsync(Request);
            await _uow.CommitAsync();
            return "Success";
        }
        catch (Exception ex)
        {

            throw new Exception(ex.ToString());
        }

    }
    #endregion

}