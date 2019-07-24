using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHire.Core.Domain.Entities
{
    public class Role
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddedBy { get; set; }
        public virtual Admin Admin { get; set; }

        //public Role(EntityTypeBuilder<Role> entityBuilder)
        //{
        //    entityBuilder.HasKey(t => t.Id);
        //    entityBuilder.Property(t => t.Name).IsRequired();
        //    entityBuilder.Property(t => t.AddedBy).IsRequired();
        //}
    }
}
