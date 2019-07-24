using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHire.Core.Domain.Entities
{
    public class Region
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int AddedBy { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual IEnumerable<Town> Towns { get; set; }
        public virtual IEnumerable<Institution> Institutions { get; set; }
        public virtual IEnumerable<HireRequest> HireRequest { get; set; }

        //public Region(EntityTypeBuilder<Region> entityBuilder)
        //{
        //    entityBuilder.HasKey(t => t.Id);
        //    entityBuilder.Property(t => t.Name).IsRequired();
        //    entityBuilder.Property(t => t.Code).IsRequired();
        //    entityBuilder.Property(t => t.AddedBy).IsRequired();
        //}
    }
}
