using Domain.Common;

namespace Domain.Entities;

public class Report : Base
{
    public int RapportId { get; set; }
    public string NomRapport { get; set; }
    public string Description { get; set; }
    public DateTime DateCreation { get; set; }
    public string CheminFichier { get; set; }
}