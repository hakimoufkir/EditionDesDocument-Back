using Application.Interfaces;
using Application.IServices;
using Application.IUnitOfWorks;
using Domain.Entities;
using Domain.Enums;
using MediatR;

namespace Application.Services;

public class RequestService : IRequestService
{
    #region Props
    private readonly IUnitOfWork _unitOfWork;
    #endregion     
    #region Constructor
    public RequestService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    #endregion
    #region Methods
    public async Task<List<Request>> GetRequestsListAsync()
    {
        List<Request> requestsList = await _unitOfWork.RequestRepository.GetAllAsNoTracking();
        return requestsList;

    }

    public async Task<Request> GetRequestByIdAsync(Guid IdRequest)
    {
        return await _unitOfWork.RequestRepository.GetByIdAsync(IdRequest);
    }

    public async Task<string> AddRequestAsync(Request Request)
    {
       /* if (await _checkRoleService.CheckRole(Request))
        {
            return Roles.RolesPermission.Permission;
        }
*/
        try
        {
            await _unitOfWork.RequestRepository.CreateAsync(Request);
            await _unitOfWork.CommitAsync();
            return ResponsStutusHandler.Status.Success.ToString();
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
            await _unitOfWork.RequestRepository.UpdateAsync(request);
            await _unitOfWork.CommitAsync();
            return ResponsStutusHandler.Status.Success.ToString();
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
        return await _unitOfWork.RequestRepository.GetPagedRequestsAsync(skip, pageSize);
    }
    #endregion

}