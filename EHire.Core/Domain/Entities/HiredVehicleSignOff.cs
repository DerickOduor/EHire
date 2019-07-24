using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHire.Core.Domain.Entities
{
    public class HiredVehicleSignOff
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int HireRequestId { get; set; }
        public bool CustomerSignOff { get; set; }
        public bool InstitutionSignOff { get; set; }
        public virtual HireRequest HireRequest { get; set; }
    }
}
