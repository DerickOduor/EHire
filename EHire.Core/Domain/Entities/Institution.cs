using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHire.Core.Domain.Entities
{
    public class Institution
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string PostalAddress { get; set; }
        public string Email { get; set; }
        public DateTime DateRegistered { get; set; }
        public bool Approved { get; set; }
        public bool Locked { get; set; }
        public int RegionId { get; set; }
        public virtual Region Region { get; set; }
        [ForeignKey("Town")]
        public int TownId { get; set; }
        public virtual Town Town { get; set; }
        public virtual IEnumerable<Vehicle> Vehicles { get; set; }
        public virtual IEnumerable<InstitutionUser> InstitutionUsers { get; set; }
    }
}
