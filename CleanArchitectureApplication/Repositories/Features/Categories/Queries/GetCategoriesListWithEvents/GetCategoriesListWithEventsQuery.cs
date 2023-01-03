using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;

namespace CleanArchitectureApplication.Repositories.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class GetCategoriesListWithEventsQuery : IRequest<List<CategoryEventListVM>>
    {
        public bool IncludeHistory { get; set; }
    }

}
