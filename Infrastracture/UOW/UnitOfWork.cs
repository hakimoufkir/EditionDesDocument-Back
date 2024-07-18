using Application.IRepository;
using Application.IServices;
using Application.IUOW;
using Infrastructure.Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IRequestRepository RequestRepository { get; }

        public ICheckRoleRepository CheckRoleRepository => throw new NotImplementedException();

        public IFileManagementService FileManagementService { get;  }
        //public IDocumentRepository DocumentRepository { get;  }

        public IFileManagementService fileManagementService => throw new NotImplementedException();

        public UnitOfWork(ApplicationDbContext db, IRequestRepository requestRepository, IFileManagementService fileManagementService
                        )
        {
            _db = db;
            RequestRepository = requestRepository;
            FileManagementService = fileManagementService;
            //DocumentRepository = documentRepository;
        }


        public void Commit()
        {
            _db.SaveChanges();
        }

        public async Task CommitAsync()
        {
           await _db.SaveChangesAsync();
        }

        public void Rollback()
        {
            _db.SaveChanges();
        }

        public async Task RollbackAsync()
        {
            await _db.SaveChangesAsync();
        }
    }

}
