using Domain.Entities;

namespace Application.Interfaces;

public interface IRequestService
{
    Task<List<Requests>> GetRequestsListAsync();
    Task<Requests> GetRequestByIdAsync(Guid IdRequest);
    Task<string> AddRequestAsync(Requests Request);

}