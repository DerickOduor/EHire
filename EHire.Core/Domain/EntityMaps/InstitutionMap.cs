using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class InstitutionMap
    {
        public InstitutionMap(EntityTypeBuilder<Institution> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Name).IsRequired();
            entityTypeBuilder.Property(t => t.RegionId).IsRequired();
            entityTypeBuilder.Property(t => t.TownId).IsRequired();
            entityTypeBuilder.Property(t => t.PhoneNo).IsRequired();
            entityTypeBuilder.Property(t => t.PostalAddress).IsRequired();
            entityTypeBuilder.Property(t => t.Email).IsRequired();
            entityTypeBuilder.Property(t => t.DateRegistered).IsRequired();
            entityTypeBuilder.Property(t => t.Approved);
            entityTypeBuilder.Property(t => t.Locked);
            entityTypeBuilder.HasOne(t => t.Region).WithMany(r => r.Institutions).HasForeignKey(x => x.RegionId).OnDelete(DeleteBehavior.Restrict);
            //entityTypeBuilder.HasOne(t => t.Town).WithMany(r => r.Institutions).HasForeignKey(x => x.TownId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
