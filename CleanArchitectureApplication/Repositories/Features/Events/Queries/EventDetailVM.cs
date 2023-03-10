using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitectureDomain.Entities;

namespace CleanArchitectureApplication.Repositories.Features.Events.Queries
{
    public class EventDetailVM
    {
        public Guid EventId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public string? Artist { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public Guid CategoryId { get; set; }
        public CategoryDTO Category { get; set; } = default!;
    }
}
