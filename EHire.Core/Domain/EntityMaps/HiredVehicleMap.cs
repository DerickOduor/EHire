using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class HiredVehicleMap
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public int HireRequestId { get; set; }
        public DateTime DateHired { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual HireRequest HireRequest { get; set; }
        public HiredVehicleMap(EntityTypeBuilder<HiredVehicle> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.VehicleId).IsRequired();
            entityTypeBuilder.Property(t => t.CustomerId).IsRequired();
            entityTypeBuilder.Property(t => t.HireRequestId).IsRequired();
            entityTypeBuilder.Property(t => t.DateHired).IsRequired();
            entityTypeBuilder.HasOne(t => t.Vehicle).WithMany(r => r.HiredVehicles).HasForeignKey(x => x.VehicleId).OnDelete(DeleteBehavior.Restrict);
            //entityTypeBuilder.HasOne(t => t.Customer).WithMany(r => r.HiredVehicles).HasForeignKey(x => x.CustomerId).OnDelete(DeleteBehavior.Restrict);
            entityTypeBuilder.HasOne(t => t.HireRequest).WithMany(r => r.HiredVehicles).HasForeignKey(x => x.HireRequestId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
