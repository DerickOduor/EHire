using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class TownMap
    {
        public TownMap(EntityTypeBuilder<Town> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Name).IsRequired();
            entityTypeBuilder.Property(t => t.RegionId).IsRequired();
            entityTypeBuilder.Property(t => t.AddedBy).IsRequired();
            //entityTypeBuilder.HasOne(t => t.Admin).WithMany(r => r.Towns).HasForeignKey(x => x.AddedBy).OnDelete(DeleteBehavior.Restrict);
            entityTypeBuilder.HasOne(t => t.Region).WithMany(r => r.Towns).HasForeignKey(x => x.RegionId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
