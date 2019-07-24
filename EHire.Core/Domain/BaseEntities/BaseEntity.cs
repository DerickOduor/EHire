using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.BaseEntities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
