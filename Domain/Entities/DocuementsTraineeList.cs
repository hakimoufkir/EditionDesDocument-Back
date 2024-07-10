using Domain.Dtos.Service1;

namespace Domain.Entities;

public class DocuementsTraineeList : Documents
{
    public List<Guid> IdTraineesList { get; set; }
}