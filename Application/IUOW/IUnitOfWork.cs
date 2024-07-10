

using Application.IRepository;

namespace Application.IUOW;

public interface IUnitOfWork
{
    IRequestRepository RequestRepository { get; }
    void Commit();
    Task CommitAsync();
    void Rollback();
    Task RollbackAsync();
}