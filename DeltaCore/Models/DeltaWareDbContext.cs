using Microsoft.EntityFrameworkCore;

namespace DeltaCore.Models
{
    public class DeltaWareDbContext : DbContext

    {
        public DbSet<Product> Products { get; set; }
        public DeltaWareDbContext(DbContextOptions<DeltaWareDbContext> options)
            : base(options)
        { 
        }

    }
}
