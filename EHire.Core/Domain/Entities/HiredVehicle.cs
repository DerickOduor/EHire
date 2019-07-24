using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHire.Core.Domain.Entities
{
    public class HiredVehicle
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public int HireRequestId { get; set; }
        public DateTime DateHired { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual HireRequest HireRequest { get; set; }

    }
}
