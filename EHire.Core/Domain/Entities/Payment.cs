using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHire.Core.Domain.Entities
{
    public class Payment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int HireRequestId { get; set; }
        public decimal TotalCost { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime DatePaid { get; set; }
        public bool IsPaid { get; set; }
        public virtual HireRequest HireRequest { get; set; }
    }
}
