using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class VehicleMaitenanceMap
    {
        public int Id { get; set; }
        public int MaintenanceTypeId { get; set; }
        public string Description { get; set; }
        public int VehicleId { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateCompleted { get; set; }
        public virtual MaintenanceType MaintenanceType { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public VehicleMaitenanceMap(EntityTypeBuilder<VehicleMaitenance> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.MaintenanceTypeId).IsRequired();
            entityTypeBuilder.Property(t => t.Description).IsRequired();
            entityTypeBuilder.Property(t => t.VehicleId).IsRequired();
            entityTypeBuilder.Property(t => t.Status);
            entityTypeBuilder.Property(t => t.DateAdded).IsRequired();
            entityTypeBuilder.Property(t => t.DateCompleted);
            entityTypeBuilder.HasOne(t => t.Vehicle).WithMany(r => r.VehicleMaitenances).HasForeignKey(x => x.VehicleId).OnDelete(DeleteBehavior.Restrict);
            entityTypeBuilder.HasOne(t => t.MaintenanceType).WithMany(r => r.VehicleMaitenances).HasForeignKey(x => x.MaintenanceTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
