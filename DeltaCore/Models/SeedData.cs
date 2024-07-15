using DeltaCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DeltaCore.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DeltaWareDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<DeltaWareDbContext>>()))
            {
                
                if (context.Products.Any())
                {
                    return;   
                }

                context.Products.AddRange(
                    new Product
                    {
                        ProductId = 1001,
                        Name = "Tools",
                        Description = "Gear tools production specification"
                    },
                    new Product
                    {
                        ProductId = 2001,
                        Name = "Panels",
                        Description = "Switch Gear Panels"
                    },
                    new Product
                    {
                        ProductId = 2008,
                        Name = "DocTonar",
                        Description = "Document Solar Objects"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

