

using Application.IRepository;
using Application.IServices;

namespace Application.IUnitOfWorks;

public interface IUnitOfWork
{
    IRequestRepository RequestRepository { get; }
    IDocumentRepository DocumentRepository { get; }

    ITraineeRepository TraineeRepository { get; }

   IGroupRepository GroupRepository { get; }
   
    void Commit();
    Task CommitAsync();
    void Rollback();
    Task RollbackAsync();
}