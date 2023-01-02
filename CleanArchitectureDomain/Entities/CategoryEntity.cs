using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CleanArchitectureDomain.Common;

namespace CleanArchitectureDomain.Entities
{
    public class CategoryEntity : LogsEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<EventEntity>? Events { get; set; }
    }
}
