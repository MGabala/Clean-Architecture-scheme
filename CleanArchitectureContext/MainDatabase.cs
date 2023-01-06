using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CleanArchitectureDomain.Entities;

using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureContext
{
    public class MainDatabase : DbContext
    {
        public MainDatabase(DbContextOptions<MainDatabase> options) : base(options)
        {
        }
        public DbSet<CategoryEntity> Categories => Set<CategoryEntity>();
        public DbSet<EventEntity> Events => Set<EventEntity>();
        public DbSet<OrderEntity> Orders => Set<OrderEntity>();
    }
}
