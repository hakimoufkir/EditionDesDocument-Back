using Application.IRepository;
using Application.IUnitOfWorks;
using Infrastructure.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public IRequestRepository RequestRepository { get; }
        public IDocumentRepository DocumentRepository { get; }

        public ITraineeRepository TraineeRepository { get; }
        public IYearRepository YearRepository { get; }
        public IGroupRepository GroupRepository { get; }

        public UnitOfWork(ApplicationDbContext dbContext, IRequestRepository requestRepository,  IDocumentRepository documentRepository, ITraineeRepository traineeRepository, IYearRepository yearRepository, IGroupRepository groupRepository)
        {
            _dbContext = dbContext;
            RequestRepository = requestRepository;
            DocumentRepository = documentRepository;
            TraineeRepository = traineeRepository;
            YearRepository = yearRepository;
            GroupRepository = groupRepository;
        }   

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        //public async Task CommitAsync()
        //{
        //   await _dbContext.SaveChangesAsync();
        //}

        public async Task CommitAsync()
        {
            try
            {
                await _dbContext.SaveChangesAsync();

            }
            catch (DbUpdateException ex)
            {
                var innerException = ex.InnerException != null ? $" Inner exception: {ex.InnerException.Message}" : string.Empty;
                throw new ApplicationException($"An error occurred while saving changes to the database.{innerException}", ex);

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
