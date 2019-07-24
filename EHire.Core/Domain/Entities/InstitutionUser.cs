using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHire.Core.Domain.Entities
{
    public class InstitutionUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int InstitutionId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        public DateTime DatAdded { get; set; }
        public bool Approved { get; set; }
        public bool Locked { get; set; }
        public int AddedBy { get; set; }
        public virtual Institution Institution { get; set; }
    }
}
