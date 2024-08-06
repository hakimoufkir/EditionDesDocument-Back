
using Application.IServices;

namespace Application.Interfaces
{
    public interface IUnitOfService
    {

        IRequestService RequestService { get; }
        IFileManagementService FileManagementService { get; }

        IDocumentService DocumentService { get; }

        ITraineeService TraineeService { get; }
        IYearService YearService { get; }
        IGroupService GroupService { get; }

        IPaymentService PaymentService { get; }


    }
}
