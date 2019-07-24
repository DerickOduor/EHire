using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class PaymentMap
    {
        public PaymentMap(EntityTypeBuilder<Payment> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.HireRequestId).IsRequired();
            entityTypeBuilder.Property(t => t.TotalCost).IsRequired();
            entityTypeBuilder.Property(t => t.AmountPaid);
            entityTypeBuilder.Property(t => t.DatePaid);
            entityTypeBuilder.Property(t => t.IsPaid);
            entityTypeBuilder.HasOne(t => t.HireRequest).WithMany(r => r.Payments).HasForeignKey(x => x.HireRequestId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
