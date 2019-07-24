using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class HiringActivityMap
    {
        public HiringActivityMap(EntityTypeBuilder<HiringActivity> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Activity).IsRequired();
            entityTypeBuilder.Property(t => t.AddedBy).IsRequired();
            entityTypeBuilder.HasOne(t => t.Admin).WithMany(r => r.HiringActivities).HasForeignKey(x => x.AddedBy).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
