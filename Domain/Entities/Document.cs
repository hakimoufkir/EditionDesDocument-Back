
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;

namespace Domain.Entities;

public class Document : Base
{
    public string PathFile { get; set; }

    public string? InstantJSON { get; set; }

    public bool? FirstYear { get; set; }
    public bool? SecondYear { get; set; }
    public string? Name { get; set; }
    public virtual Request? Request { get; set; }

}