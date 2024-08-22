using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PrintDocumentRequest
    {
        public Guid IdTrainee { get; set; }
        public Guid DocumentId { get; set; }
    }
}
