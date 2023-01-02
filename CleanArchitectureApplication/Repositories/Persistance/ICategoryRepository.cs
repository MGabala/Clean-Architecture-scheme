﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CleanArchitectureDomain.Entities;

namespace CleanArchitectureApplication.Repositories.Persistance
{
    public interface ICategoryRepository : IAsyncRepository<CategoryEntity>
    {
        Task<List<CategoryEntity>> GetCategoriesWithEvents(bool includePassedEvents);
    }
}
