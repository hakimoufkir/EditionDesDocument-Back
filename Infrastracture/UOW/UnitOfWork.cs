using Application.IRepository;
using Application.IUOW;
using Infrastructure.Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IRequestRepository RequestRepository { get; }

        public ICheckRoleRepository CheckRoleRepository => throw new NotImplementedException();

        public UnitOfWork(ApplicationDbContext db, IRequestRepository requestRepository)
        {
            _db = db;
            RequestRepository = requestRepository;
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
