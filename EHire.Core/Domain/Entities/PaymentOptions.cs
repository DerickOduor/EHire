using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHire.Core.Domain.Entities
{
    public class PaymentOptions
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string BillNo { get; set; }
        public byte[] Logo { get; set; }
        public int AddedBy { get; set; }
        public bool Status { get; set; }
        public virtual Admin Admin { get; set; }
    }
}
