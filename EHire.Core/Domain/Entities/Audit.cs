using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHire.Core.Domain.Entities
{
    public class Audit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Action { get; set; }
        public  DateTime ActionTime { get; set; }
        public int UserId { get; set; }
        public int UsertypeId { get; set; }
        public virtual UserTypes UserTypes { get; set; }
    }
}
