using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Common
{
    public class NamedEntity:AuditEntity
    {
        public string Name { get; set; }
    }
}
