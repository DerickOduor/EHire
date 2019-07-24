using EHire.Core.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHire.Core.Domain.Entities
{
    public class MaintenanceType /*: BaseEntity*/
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public string Maintenance { get; set; }
        public int AddedBy { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual IEnumerable<VehicleMaitenance> VehicleMaitenances { get; set; }
    }
}
