using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CleanArchitectureDomain.Common;

namespace CleanArchitectureDomain.Entities
{
    public class OrderEntity : LogsEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
        public bool OrderPaid { get; set; }
    }
}
