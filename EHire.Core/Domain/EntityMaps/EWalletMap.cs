using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class EWalletMap
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int UserTypeId { get; set; }
        public decimal Balance { get; set; }
        public virtual UserTypes UserTypes { get; set; }
        public EWalletMap(EntityTypeBuilder<EWallet> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.UserId).IsRequired();
            entityTypeBuilder.Property(t => t.UserTypeId).IsRequired();
            entityTypeBuilder.Property(t => t.Balance).IsRequired();
            entityTypeBuilder.HasOne(t => t.UserTypes).WithMany(r => r.EWallets).HasForeignKey(x => x.UserTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
