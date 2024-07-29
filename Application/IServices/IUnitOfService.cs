
using Application.IServices;

namespace Application.Interfaces
{
    public interface IUnitOfService
    {

        IRequestService RequestService { get; }
        IFileManagementService FileManagementService { get; }

        IDocumentService DocumentService { get; }

        ITraineeService TraineeService { get; }
        IGroupService GroupService { get; }


    }
}
