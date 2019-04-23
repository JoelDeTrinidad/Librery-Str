using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Librery_Str.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LibreryStrContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LibreryStrContext>>()))
            {
                // Look for any Product.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                    new Product
                    {
                        Name = "Cuaderno rayado",
                        Price = 30,
                        Stock = 10,
                        Description = "Cuarderno rayado pequeño Scribe",
                        CreateDate = DateTime.Parse("2019-04-06"),
                        Brand = "Scribe",
                        
                    },

                    new Product
                    {
                        Name = "Cuaderno cuadriculado",
                        Price = 30,
                        Stock = 15,
                        Description = "Cuarderno cuadriculado pequeño Scribe",
                        CreateDate = DateTime.Parse("2019-04-06"),
                        Brand = "Scribe",
                    },

                    new Product
                    {
                        Name = "Cuaderno pautado",
                        Price = 45,
                        Stock = 15,
                        Description = "Cuarderno pautado Scribe",
                        CreateDate = DateTime.Parse("2019-04-07"),
                        Brand = "Scribe",
                    },

                    new Product
                    {
                        Name = "Cuaderno uni rayado",
                        Price = 35,
                        Stock = 10,
                        Description = "Cuarderno uni rayado Scribe",
                        CreateDate = DateTime.Parse("2019-04-07"),
                        Brand = "Loro",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}