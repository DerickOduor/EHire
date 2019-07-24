using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHire.Core.Domain.Entities
{
    public class UserTypes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddedBy { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public int AdminId { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual IEnumerable<Passwords> Passwords { get; set; }
        public virtual IEnumerable<Mail> Mails { get; set; }
        public virtual IEnumerable<Audit> Audits { get; set; }
        public virtual IEnumerable<EWallet> EWallets { get; set; }
        public virtual IEnumerable<Login> Logins { get; set; }
    }
}
