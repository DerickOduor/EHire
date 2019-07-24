using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class PaymentOptionsMap
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string BillNo { get; set; }
        public byte[] Logo { get; set; }
        public int AddedBy { get; set; }
        public bool Status { get; set; }
        public PaymentOptionsMap(EntityTypeBuilder<PaymentOptions> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Name).IsRequired();
            entityTypeBuilder.Property(t => t.Code).IsRequired();
            entityTypeBuilder.Property(t => t.AddedBy).IsRequired();
            entityTypeBuilder.Property(t => t.BillNo).IsRequired();
            entityTypeBuilder.Property(t => t.Status).IsRequired();
            entityTypeBuilder.Property(t => t.Logo);
            entityTypeBuilder.HasOne(t => t.Admin).WithMany(r => r.PaymentOptions).HasForeignKey(x => x.AddedBy).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
