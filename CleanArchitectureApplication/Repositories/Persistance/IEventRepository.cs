using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CleanArchitectureDomain.Entities;

namespace CleanArchitectureApplication.Repositories.Persistance
{
    public interface IEventRepository : IAsyncRepository<EventEntity>
    {
        Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);
    }
}
