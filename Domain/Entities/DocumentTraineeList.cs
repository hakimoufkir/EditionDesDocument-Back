using Domain.Dtos.Service1;

namespace Domain.Entities;

public class DocumentTraineeList : Document
{
    public List<Guid> IdTraineesList { get; set; }
}