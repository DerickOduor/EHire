using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class LoginMap
    {
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
        public LoginMap(EntityTypeBuilder<Login> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.UserTypeId).IsRequired();
            entityTypeBuilder.Property(t => t.UserId).IsRequired();
            entityTypeBuilder.Property(t => t.UserName).IsRequired();
            entityTypeBuilder.Property(t => t.IsLoggedIn);
            entityTypeBuilder.Property(t => t.PasswordReset);
            entityTypeBuilder.Property(t => t.Locked);
            entityTypeBuilder.Property(t => t.ReasonId);
            entityTypeBuilder.Property(t => t.LoginTime);
            entityTypeBuilder.Property(t => t.LogoutTime);
            entityTypeBuilder.Property(t => t.SecurityCode);
            entityTypeBuilder.Property(t => t.SecurityCodeExpiry);
            entityTypeBuilder.HasOne(t => t.UserTypes).WithMany(r => r.Logins).HasForeignKey(x => x.UserTypeId).OnDelete(DeleteBehavior.Restrict);
            entityTypeBuilder.HasOne(t => t.Reason).WithMany(r => r.Logins).HasForeignKey(x => x.ReasonId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
