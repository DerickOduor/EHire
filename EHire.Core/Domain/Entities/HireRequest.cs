using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHire.Core.Domain.Entities
{
    public class HireRequest
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public DateTime ExtendHirePeriodTo { get; set; }
        public int HireActivityId { get; set; }
        public int RegionId { get; set; }
        public int TownId { get; set; }
        public bool Approved { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual HiringActivity HiringActivity { get; set; }
        public virtual Region Region { get; set; }
        public virtual Town Town { get; set; }
        public virtual HiredVehicleSignOff HiredVehicleSignOff { get; set; }
        public virtual HiredVehicle HiredVehicle { get; set; }
        public virtual IEnumerable<HiredVehicle> HiredVehicles { get; set; }
        public virtual IEnumerable<Payment> Payments { get; set; }
    }
}
