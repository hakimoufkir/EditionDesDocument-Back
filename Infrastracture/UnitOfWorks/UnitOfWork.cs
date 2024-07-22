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

        public UnitOfWork(ApplicationDbContext dbContext, IRequestRepository requestRepository,  IDocumentRepository documentRepository)
        {
            _dbContext = dbContext;
            RequestRepository = requestRepository;
            DocumentRepository = documentRepository;
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
