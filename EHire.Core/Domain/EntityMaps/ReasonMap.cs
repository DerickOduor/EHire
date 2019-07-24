﻿using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class ReasonMap
    {
        public ReasonMap(EntityTypeBuilder<Reason> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.ReasonDescription).IsRequired();
            entityTypeBuilder.Property(t => t.DateAdded).IsRequired();
            entityTypeBuilder.Property(t => t.DateModified).IsRequired();
            entityTypeBuilder.Property(t => t.AddedBy).IsRequired();
            entityTypeBuilder.HasOne(t => t.Admin).WithMany(r => r.Reasons).HasForeignKey(x => x.AddedBy).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
