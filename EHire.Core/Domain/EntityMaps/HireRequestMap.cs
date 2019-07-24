using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class HireRequestMap
    {
        public HireRequestMap(EntityTypeBuilder<HireRequest> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.CustomerId).IsRequired();
            entityTypeBuilder.Property(t => t.VehicleId).IsRequired();
            entityTypeBuilder.Property(t => t.DateRequested).IsRequired();
            entityTypeBuilder.Property(t => t.From).IsRequired();
            entityTypeBuilder.Property(t => t.To).IsRequired();
            entityTypeBuilder.Property(t => t.ExtendHirePeriodTo).IsRequired();
            entityTypeBuilder.Property(t => t.HireActivityId).IsRequired();
            entityTypeBuilder.Property(t => t.RegionId).IsRequired();
            entityTypeBuilder.Property(t => t.TownId).IsRequired();
            entityTypeBuilder.Property(t => t.Approved);
            entityTypeBuilder.Property(t => t.HireActivityId).IsRequired();
            //entityTypeBuilder.HasOne(t => t.Customer).WithMany(r => r.HireRequest).HasForeignKey(x => x.CustomerId).OnDelete(DeleteBehavior.Restrict);
            entityTypeBuilder.HasOne(t => t.Vehicle).WithMany(r => r.HireRequests).HasForeignKey(x => x.VehicleId).OnDelete(DeleteBehavior.Restrict);
            entityTypeBuilder.HasOne(t => t.HiringActivity).WithMany(r => r.HireRequest).HasForeignKey(x => x.VehicleId).OnDelete(DeleteBehavior.Restrict);
            entityTypeBuilder.HasOne(t => t.Region).WithMany(r => r.HireRequest).HasForeignKey(x => x.RegionId).OnDelete(DeleteBehavior.Restrict);
            //entityTypeBuilder.HasOne(t => t.Town).WithMany(r => r.HireRequest).HasForeignKey(x => x.TownId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
