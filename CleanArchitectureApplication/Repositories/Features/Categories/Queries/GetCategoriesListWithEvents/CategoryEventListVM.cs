using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureApplication.Repositories.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class CategoryEventListVM
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<CategoryEventDTO> Events { get; set; }
    }
}
