using Domain.Entities;

namespace Application.IRepository;

public interface 
    
    
    IRequestRepository: IGenericRepository<Request>
{
    Task<Request> GetByIdAsync(Guid id);
    Task UpdateAsync(Request request);
    Task CreateAsync(Request request);
    Task<List<Request>> GetAllAsNoTracking();

    Task<List<Request>> GetPagedRequestsAsync(int page, int pageSize);
}