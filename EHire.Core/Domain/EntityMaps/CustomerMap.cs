using EHire.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.EntityMaps
{
    public class CustomerMap
    {
        public CustomerMap(EntityTypeBuilder<Customer> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.HasKey(t => t.DateAdded);
            entityTypeBuilder.HasKey(t => t.DateModified);
            entityTypeBuilder.Property(t => t.UserName).IsRequired();
            entityTypeBuilder.Property(t => t.FirstName).IsRequired();
            entityTypeBuilder.Property(t => t.LastName).IsRequired();
            entityTypeBuilder.Property(t => t.OtherName).IsRequired();
            entityTypeBuilder.Property(t => t.Password).IsRequired();
            entityTypeBuilder.Property(t => t.Phone).IsRequired();
            entityTypeBuilder.Property(t => t.Email).IsRequired();
            entityTypeBuilder.Property(t => t.Approved);
            entityTypeBuilder.Property(t => t.Locked);
        }
    }
}
