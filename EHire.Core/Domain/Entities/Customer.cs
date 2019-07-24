using EHire.Core.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EHire.Core.Domain.Entities
{
    public class Customer/* : BaseEntity*/
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool Approved { get; set; }
        public bool Locked { get; set; }
        public virtual IEnumerable<HireRequest> HireRequest { get; set; }
        public virtual IEnumerable<HiredVehicle> HiredVehicles { get; set; }
    }
}
