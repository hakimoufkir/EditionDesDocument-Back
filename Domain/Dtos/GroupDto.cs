using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class GroupDto 
    {
        public string? Name { get; set; }
        
        public int? Capacity { get; set; }
        public Guid? YearId { get; set; }
    }
}
