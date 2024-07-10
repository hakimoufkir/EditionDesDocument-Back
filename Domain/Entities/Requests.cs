using Domain.Common;
using Domain.Enums;

namespace Domain.Entities;

public class Requests : Base
{
    public Guid IdTrainee { get; set; }
    public Guid ModeleId { get; set; }
    public string role { get; set; }
    public string DocumentType { get; set; }
    public DocumentStatus DocumentStatus{ get; set; }

}