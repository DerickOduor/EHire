using EHire.Core.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHire.Core.Domain.Entities
{
    public class VehicleModel/* : BaseEntity*/
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public string Model { get; set; }
        public int VehicleBrandId { get; set; }
        public int AddedBy { get; set; }
        public virtual VehicleBrand VehicleBrand { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual IEnumerable<Vehicle> Vehicles { get; set; }
    }
}
