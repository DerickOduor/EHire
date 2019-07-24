﻿using EHire.Core.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHire.Core.Domain.Entities
{
    public class Town/* : BaseEntity*/
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; }
        public int AddedBy { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual Region Region { get; set; }
        public virtual IEnumerable<Institution> Institutions { get; set; }
        public virtual IEnumerable<HireRequest> HireRequest { get; set; }
    }
}
