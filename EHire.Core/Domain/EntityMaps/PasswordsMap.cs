using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class PasswordsMap
    {
        public PasswordsMap(EntityTypeBuilder<Passwords> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.UsertypeId).IsRequired();
            entityTypeBuilder.Property(t => t.UserId).IsRequired();
            entityTypeBuilder.Property(t => t.Password).IsRequired();
            entityTypeBuilder.Property(t => t.DateAdded).IsRequired();
            entityTypeBuilder.HasOne(t => t.UserTypes).WithMany(r => r.Passwords).HasForeignKey(x => x.UsertypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
