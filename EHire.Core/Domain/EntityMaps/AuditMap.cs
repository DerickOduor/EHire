using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class AuditMap
    {

        public AuditMap(EntityTypeBuilder<Audit> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Action).IsRequired();
            entityTypeBuilder.Property(t => t.ActionTime).IsRequired();
            entityTypeBuilder.Property(t => t.UserId).IsRequired();
            entityTypeBuilder.Property(t => t.UsertypeId).IsRequired();
            entityTypeBuilder.HasOne(t => t.UserTypes).WithMany(r => r.Audits).HasForeignKey(x => x.UsertypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
