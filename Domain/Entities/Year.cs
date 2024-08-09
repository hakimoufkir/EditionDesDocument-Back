using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Year : Base
    {
        
       
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
     
        //public List<Group>? Groups { get; set; }
        public bool current { get; set; }
    }
}
