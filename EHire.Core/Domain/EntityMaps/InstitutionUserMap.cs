using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class InstitutionUserMap
    {
        public InstitutionUserMap(EntityTypeBuilder<InstitutionUser> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.RoleId);
            entityTypeBuilder.Property(t => t.AddedBy).IsRequired();
            entityTypeBuilder.Property(t => t.UserName).IsRequired();
            entityTypeBuilder.Property(t => t.FirstName).IsRequired();
            entityTypeBuilder.Property(t => t.LastName).IsRequired();
            entityTypeBuilder.Property(t => t.OtherName).IsRequired();
            entityTypeBuilder.Property(t => t.DatAdded).IsRequired();
            entityTypeBuilder.Property(t => t.Approved);
            entityTypeBuilder.Property(t => t.Locked);
            entityTypeBuilder.HasOne(t => t.Institution).WithMany(r => r.InstitutionUsers).HasForeignKey(x => x.InstitutionId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
