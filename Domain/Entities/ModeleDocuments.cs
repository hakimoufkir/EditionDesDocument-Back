using System.Runtime.InteropServices.JavaScript;
using Domain.Common;

namespace Domain.Entities;

public class ModeleDocuments : Base
{
    public Guid ModeleId { get; set; }
    public string NomModele { get; set; }
    public string Description { get; set; }
    public string FilePath { get; set; }
    // public JSObject params { get; set; }
}

