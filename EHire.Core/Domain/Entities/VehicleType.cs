using EHire.Core.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EHire.Core.Domain.Entities
{
    public class VehicleType /*: BaseEntity*/
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public string Name { get; set; }
        public int AddedBy { get; set; }
        public int AdminId { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual IEnumerable<VehicleBrand> VehicleBrands { get; set; }
    }
}
