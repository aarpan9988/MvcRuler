using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcRuler.Data;
using System;
using System.Linq;

namespace MvcRuler.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)         // I created my entries for the SeedData , This is my data of the application.
        {
            using (var context = new MvcRulerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcRulerContext>>()))
            {
                // Look for any movies.
                if (context.Ruler.Any())
                {
                    return;                  // DB has been seeded
                }

                context.Ruler.AddRange(
                    new Ruler
                    {
                        Title = "Hook ruler",
                        Purpose = "Woodworking ",
                        Material = "Romantic Comedy",
                        Length = 150.0M,
                        Price = 12.99M
                    },

                    new Ruler
                    {
                        Title = "Desk ruler ",
                        Purpose = "Engineering",
                        Material = "Wood, Plastic",
                        Length = 30.0M,
                        Price = 8.99M
                    },

                    new Ruler
                    {
                        Title = " Folded ruler",
                        Purpose = " Carpenters",
                        Material = "HardWood",
                        Length = 60.0M,
                        Price = 13.69M
                    },

                    new Ruler
                    {
                        Title = "Machinist ruler",
                        Purpose = "mechanics",
                        Material = "Western",
                        Length = 15.24M,
                        Price = 23.79M
                    },

                    new Ruler
                    {
                        Title = "Yardsticks",
                        Purpose = "Construction",
                        Material = "Wood",
                        Length = 91.44M,
                        Price = 3.99M
                    },

                    new Ruler
                    {
                        Title = "Seamstress tape",
                        Purpose = "Sewing ,Craft",
                        Material = "Nylon",
                        Length = 76.2M,
                        Price = 6.99M
                    },

                    new Ruler
                    {
                        Title = "Architect scale",
                        Purpose = "Orthographic projection",
                        Material = "Plastic ",
                        Length = 14.9M,
                        Price = 26.89M
                    },

                    new Ruler
                    {
                        Title = "Narrow ruler",
                        Purpose = "Construction",
                        Material = "Wood, Plastic, Steel",
                        Length = 30.0M,
                        Price = 12.69M
                    },

                    new Ruler
                    {
                        Title = "Protractor",
                        Purpose = "Architectural Drawing",
                        Material = "Transparent Plastic",
                        Length = 15.6M,
                        Price = 35.99M
                    },

                    new Ruler
                    {
                        Title = "Caliper ruler",
                        Purpose = "Depth measurements",
                        Material = "Steel",
                        Length = 38.8M,
                        Price = 28.79M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}