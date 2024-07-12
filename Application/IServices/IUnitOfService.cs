
using Application.IServices;

namespace Application.Interfaces
{
    public interface IUnitOfService
    {

        IRequestService RequestService { get; }
        ICheckRoleService CheckRoleService { get; }

       

    }
}
