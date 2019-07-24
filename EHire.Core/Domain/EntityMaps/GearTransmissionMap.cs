using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class GearTransmissionMap
    {
        public GearTransmissionMap(EntityTypeBuilder<GearTransmission> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Transmission).IsRequired();
            entityTypeBuilder.Property(t => t.AddedBy).IsRequired();
            entityTypeBuilder.Property(t => t.DateAdded).IsRequired();
            entityTypeBuilder.Property(t => t.DateModified).IsRequired();
            entityTypeBuilder.HasOne(t => t.Admin).WithMany(r => r.GearTransmissions).HasForeignKey(x => x.AddedBy).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
