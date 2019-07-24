using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHire.Core.Domain.Entities
{
    public class VehicleMaitenance
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int MaintenanceTypeId { get; set; }
        public string Description { get; set; }
        public int VehicleId { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateCompleted { get; set; }
        public virtual MaintenanceType MaintenanceType { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
