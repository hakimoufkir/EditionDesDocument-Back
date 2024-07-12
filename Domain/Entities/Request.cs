using Domain.Common;
using Domain.Enums;

namespace Domain.Entities;

public class Request : Base
{
    public Guid IdTrainee { get; set; }
    public string? NameTrainee { get; set; }
    public Guid ModeleId { get; set; }
    public string Role { get; set; }
    public string DocumentType { get; set; }
    public DocumentStatus DocumentStatus{ get; set; }
    public string ReasonRejection { get; set; }

}