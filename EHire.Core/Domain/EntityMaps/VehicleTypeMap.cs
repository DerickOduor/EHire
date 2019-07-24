using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class VehicleTypeMap
    {
        public VehicleTypeMap(EntityTypeBuilder<VehicleType> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Name).IsRequired();
            entityTypeBuilder.Property(t => t.AddedBy).IsRequired();
            entityTypeBuilder.Property(t => t.DateAdded).IsRequired();
            entityTypeBuilder.Property(t => t.DateModified).IsRequired();
        }
    }
}
