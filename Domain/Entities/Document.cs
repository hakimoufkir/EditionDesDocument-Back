
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;

namespace Domain.Entities;

public class Document : Base
{
    public string PathFile { get; set; }

    public string? InstantJSON { get; set; }

    // public string Type { get; set; }

}