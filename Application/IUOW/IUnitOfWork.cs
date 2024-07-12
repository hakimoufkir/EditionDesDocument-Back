

using Application.IRepository;
using Application.IServices;

namespace Application.IUOW;

public interface IUnitOfWork
{
    IRequestRepository RequestRepository { get; }
    ICheckRoleRepository CheckRoleRepository { get; }
    void Commit();
    Task CommitAsync();
    void Rollback();
    Task RollbackAsync();
}