using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Common
{
    public class AuditEntity:BaseEntity
    {
        public int? UserId { get; set; }
        public DateTime? LastEdited { get; set; }
    }
}
