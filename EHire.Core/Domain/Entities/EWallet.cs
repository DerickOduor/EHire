using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHire.Core.Domain.Entities
{
    public class EWallet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int UserTypeId { get; set; }
        public decimal Balance { get; set; }
        public virtual UserTypes UserTypes { get; set; }
    }
}
