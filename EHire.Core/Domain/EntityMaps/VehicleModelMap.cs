using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class VehicleModelMap
    {
        public VehicleModelMap(EntityTypeBuilder<VehicleModel> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Model).IsRequired();
            entityTypeBuilder.Property(t => t.VehicleBrandId).IsRequired();
            entityTypeBuilder.Property(t => t.AddedBy).IsRequired();
            entityTypeBuilder.Property(t => t.DateAdded).IsRequired();
            entityTypeBuilder.Property(t => t.DateModified).IsRequired();
            entityTypeBuilder.HasOne(t => t.Admin).WithMany(r => r.VehicleModels).HasForeignKey(x => x.AddedBy).OnDelete(DeleteBehavior.Restrict);
            entityTypeBuilder.HasOne(t => t.VehicleBrand).WithMany(r => r.VehicleModels).HasForeignKey(x => x.VehicleBrandId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
