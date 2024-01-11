using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if(!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A small boat for one person",
                        Category = "Watersports",
                        Price = 200
                    },
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A small boat for one person",
                        Category = "Watersports",
                        Price = 200
                    },
                    new Product
                    {
                        Name = "Canvas Frame",
                        Description = "A frame to put your canvas in",
                        Category = "Painting",
                        Price = 5
                    },
                    new Product
                    {
                        Name = "Dog life jacket",
                        Description = "Life jackets for small breed dogs",
                        Category = "Watersports",
                        Price = 100
                    },
                    new Product
                    {
                        Name = "Paint Brushes",
                        Description = "A bundle of pain brushes for beginners",
                        Category = "Painting",
                        Price = 20
                    }
                );
                context.SaveChanges();
            }
        }
    }
}