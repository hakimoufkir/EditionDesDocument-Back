using Application.IRepository;
using Application.IServices;
using Application.IUnitOfWorks;
using Infrastructure.Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public IRequestRepository RequestRepository { get; }

        public ICheckRoleRepository CheckRoleRepository => throw new NotImplementedException();

        public IFileManagementService FileManagementService { get;  }

      

        public IFileManagementService fileManagementService => throw new NotImplementedException();

        public UnitOfWork(ApplicationDbContext dbContext, IRequestRepository requestRepository, IFileManagementService fileManagementService
                        )
        {
            _dbContext = dbContext;
            RequestRepository = requestRepository;
            FileManagementService = fileManagementService;
           
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
