using Application.Interfaces;
using Application.IServices;
using Application.IUnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Services;

public class RequestService : IRequestService
{
    #region Props
    private readonly IUnitOfWork _unitOfService;
    private readonly ICheckRoleService _checkRoleService;
    #endregion     
    #region Constructor
    public RequestService(IUnitOfWork unitOfService, ICheckRoleService checkRoleService)
    {
        _unitOfService = unitOfService;
        _checkRoleService = checkRoleService;
    }
    #endregion
    #region Methods
    public async Task<List<Request>> GetRequestsListAsync()
    {
        List<Request> requestsList = await _unitOfService.RequestRepository.GetAllAsNoTracking();
        return requestsList;

    }

    public async Task<Request> GetRequestByIdAsync(Guid IdRequest)
    {
        return await _unitOfService.RequestRepository.GetByIdAsync(IdRequest);
    }

    public async Task<string> AddRequestAsync(Request Request)
    {
        if (await _checkRoleService.CheckRole(Request))
        {
            return "You don't have permission!";
        }

        try
        {
            await _unitOfService.RequestRepository.CreateAsync(Request);
            await _unitOfService.CommitAsync();
            return "Success";
        }
        catch (Exception ex)
        {

            throw new Exception("Error adding request: " + ex.Message);
        }

    }

    public async Task<string> UpdateRequestAsync(Request request)
    {
        try
        {
            await _unitOfService.RequestRepository.UpdateAsync(request);
            await _unitOfService.CommitAsync();
            return "Success";
        }
        catch (Exception ex)
        {
            throw new Exception("Error updating request: " + ex.Message);
        }
    }

    // New method for pagination
    public async Task<List<Request>> GetPagedRequestsAsync(int page, int pageSize)
    {
        int skip = (page - 1) * pageSize;
        return await _unitOfService.RequestRepository.GetPagedRequestsAsync(skip, pageSize);
    }
    #endregion

}