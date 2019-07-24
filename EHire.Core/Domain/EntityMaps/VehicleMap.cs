using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class VehicleMap
    {
        public VehicleMap(EntityTypeBuilder<Vehicle> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.RegistrationNumber).IsRequired();
            entityTypeBuilder.Property(t => t.EngineNumber).IsRequired();
            entityTypeBuilder.Property(t => t.FuelCapacity).IsRequired();
            entityTypeBuilder.Property(t => t.FuelConsumption).IsRequired();
            entityTypeBuilder.Property(t => t.FuelTypeId).IsRequired();
            entityTypeBuilder.Property(t => t.InstitutionId).IsRequired();
            entityTypeBuilder.Property(t => t.GearTansmissionTypeId).IsRequired();
            entityTypeBuilder.Property(t => t.SeatingCapacity).IsRequired();
            entityTypeBuilder.Property(t => t.VehicleModelId).IsRequired();
            entityTypeBuilder.HasOne(t => t.VehicleModel).WithMany(r => r.Vehicles).HasForeignKey(x => x.VehicleModelId).OnDelete(DeleteBehavior.Restrict);
            entityTypeBuilder.HasOne(t => t.Institution).WithMany(r => r.Vehicles).HasForeignKey(x => x.InstitutionId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
