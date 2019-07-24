using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHire.Core.Domain.Entities
{
    public class Mail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
        public int From { get; set; }
        public int UsertypeFrom { get; set; }
        public int To { get; set; }
        public int UsertypeTo { get; set; }
        public DateTime DateTimeSent { get; set; }
        public bool IsSent { get; set; }
        public bool IsRead { get; set; }
        public virtual UserTypes UserTypes { get; set; }
    }
}
