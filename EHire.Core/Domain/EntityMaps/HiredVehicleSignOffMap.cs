using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class HiredVehicleSignOffMap
    {
        public int Id { get; set; }
        public int HireRequestId { get; set; }
        public bool CustomerSignOff { get; set; }
        public bool InstitutionSignOff { get; set; }
        public virtual HireRequest HireRequest { get; set; }
        public HiredVehicleSignOffMap(EntityTypeBuilder<HiredVehicleSignOff> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.HireRequestId).IsRequired();
            entityTypeBuilder.Property(t => t.CustomerSignOff).IsRequired();
            entityTypeBuilder.Property(t => t.InstitutionSignOff).IsRequired();
            entityTypeBuilder.HasOne(t => t.HireRequest).WithOne(u => u.HiredVehicleSignOff).HasForeignKey<HireRequest>(x => x.Id);
        }
    }
}
