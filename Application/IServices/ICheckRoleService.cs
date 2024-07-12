using Domain.Entities;

namespace Application.IServices
{
    public interface ICheckRoleService
    {
        Task<bool> CheckRole(Request Request);
    }
}
