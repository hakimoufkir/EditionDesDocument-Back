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
        public IYearRepository YearRepository { get; }

        public UnitOfWork(ApplicationDbContext dbContext, IRequestRepository requestRepository,  IDocumentRepository documentRepository, ITraineeRepository traineeRepository, IYearRepository yearRepository)
        {
            _dbContext = dbContext;
            RequestRepository = requestRepository;
            DocumentRepository = documentRepository;
            TraineeRepository = traineeRepository;
            YearRepository = yearRepository;
        }   

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            try
            {
                await _dbContext.SaveChangesAsync();

            }
            catch (Exception ex) 
            {
                throw new ApplicationException($"Saving the Error{ex.Message} {ex.StackTrace}",ex);
            }
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
