using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHire.Core.Domain.Entities
{
    public class Login
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int UserTypeId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool IsLoggedIn { get; set; }
        public bool PasswordReset { get; set; }
        public bool Locked { get; set; }
        public int ReasonId { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime LogoutTime { get; set; }
        public string SecurityCode { get; set; }
        public DateTime SecurityCodeExpiry { get; set; }
        public virtual Reason Reason { get; set; }
        public virtual UserTypes UserTypes { get; set; }
    }
}
