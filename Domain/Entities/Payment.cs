using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    public class Payment : Base
    {
     
        public double? Amount { get; set; }
       
        public DateTime? PaymentDate { get; set; }
        
        public PaymentMethod? PaymentMethod { get; set; }
      
        public TypePayment? TypePayment { get; set; }
      
        public PaymentStatus? PaymentStatus { get; set; }
        
        [ForeignKey("Trainee")]
        public Guid IdTrainee { get; set; }
        [JsonIgnore]
        public Trainee? Trainee { get; set; }
    }
}
