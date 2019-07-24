using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHire.Core.Domain.Entities
{
    public class Passwords
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int UsertypeId { get; set; }
        public int UserId { get; set; }
        public string Password { get; set; }
        public DateTime DateAdded { get; set; }
        public virtual UserTypes UserTypes { get; set; }
    }
}
