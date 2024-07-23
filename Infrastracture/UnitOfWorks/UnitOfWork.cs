using Application.IRepository;
using Application.IUnitOfWorks;
using Infrastructure.Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public IRequestRepository RequestRepository { get; }
        public IDocumentRepository DocumentRepository { get; }

        public ITraineeRepository TraineeRepository { get; }

        public UnitOfWork(ApplicationDbContext dbContext, IRequestRepository requestRepository,  IDocumentRepository documentRepository, ITraineeRepository traineeRepository)
        {
            _dbContext = dbContext;
            RequestRepository = requestRepository;
            DocumentRepository = documentRepository;
            TraineeRepository = traineeRepository;
        }   

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
           await _dbContext.SaveChangesAsync();
        }

        public void Rollback()
        {
            _dbContext.SaveChanges();
        }

        public async Task RollbackAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }

}
