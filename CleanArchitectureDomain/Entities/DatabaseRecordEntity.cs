using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CleanArchitectureDomain.Common;

namespace CleanArchitectureDomain.Entities
{
    public class DatabaseRecordEntity : LogsEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Description { get; set; }
    }
}
