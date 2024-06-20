using Microsoft.EntityFrameworkCore;
using TechStoreAPI.Data.Entities;

namespace TechStoreAPI.Data
{
    public class TechStoreDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public TechStoreDbContext(DbContextOptions<TechStoreDbContext> options)
            : base(options)
        {
        }
    }
}
