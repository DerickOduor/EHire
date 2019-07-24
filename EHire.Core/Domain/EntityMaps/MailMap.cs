using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class MailMap
    {
        public MailMap(EntityTypeBuilder<Mail> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Message).IsRequired();
            entityTypeBuilder.Property(t => t.Subject).IsRequired();
            entityTypeBuilder.Property(t => t.From).IsRequired();
            entityTypeBuilder.Property(t => t.UsertypeFrom).IsRequired();
            entityTypeBuilder.Property(t => t.To).IsRequired();
            entityTypeBuilder.Property(t => t.UsertypeTo).IsRequired();
            entityTypeBuilder.Property(t => t.DateTimeSent).IsRequired();
            entityTypeBuilder.Property(t => t.IsSent).IsRequired();
            entityTypeBuilder.Property(t => t.IsRead).IsRequired();
            entityTypeBuilder.HasOne(t => t.UserTypes).WithMany(r => r.Mails).HasForeignKey(x => x.UsertypeTo).OnDelete(DeleteBehavior.Restrict);
            entityTypeBuilder.HasOne(t => t.UserTypes).WithMany(r => r.Mails).HasForeignKey(x => x.UsertypeFrom).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
