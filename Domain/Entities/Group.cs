using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Entities
{
    public class Group : Base
    {
        
        public string? Name { get; set; }
        public Guid? IdFiliere { get; set; }
        public int? Capacity { get; set; }

        [ForeignKey("Year")]
       
        public Guid? IdYear { get; set; }
        [JsonIgnore]
        public Year? Year { get; set; }

     

        public List<Trainee>? Trainees { get; set; }
    }
}
