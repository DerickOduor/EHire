using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class PasswordDictionaryMap
    {
        public PasswordDictionaryMap(EntityTypeBuilder<PasswordDictionary> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Password).IsRequired();
            entityTypeBuilder.Property(t => t.AddedBy).IsRequired();
            entityTypeBuilder.HasOne(t => t.Admin).WithMany(r => r.PasswordDictionaries).HasForeignKey(x => x.AddedBy).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
