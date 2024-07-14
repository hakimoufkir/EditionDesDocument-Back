using System.ComponentModel.DataAnnotations;

namespace Domain.Common;

public class Base
{
    [Key]
    public Guid Id { get; set; }
    public string? CreatedBy { get; set; } 
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public string? LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; } = DateTime.Now;
}