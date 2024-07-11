using Domain.Entities;

namespace Application.Interfaces;

public interface IRequestService
{
    Task<List<Request>> GetRequestsListAsync();
    Task<Request> GetRequestByIdAsync(Guid IdRequest);
    Task<string> AddRequestAsync(Request Request);

}