using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class VehicleBrandMap
    {
        public VehicleBrandMap(EntityTypeBuilder<VehicleBrand> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Brand).IsRequired();
            entityTypeBuilder.Property(t => t.VehicleTypeId).IsRequired();
            entityTypeBuilder.Property(t => t.AddedBy).IsRequired();
            entityTypeBuilder.Property(t => t.DateAdded).IsRequired();
            entityTypeBuilder.Property(t => t.DateModified).IsRequired();
            entityTypeBuilder.HasOne(t => t.Admin).WithMany(r => r.VehicleBrands).HasForeignKey(x => x.AddedBy).OnDelete(DeleteBehavior.Restrict);
            entityTypeBuilder.HasOne(t => t.VehicleType).WithMany(r => r.VehicleBrands).HasForeignKey(x => x.VehicleTypeId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
