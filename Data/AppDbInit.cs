using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PlantShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantShop.Data
{
    public class AppDbInit
    {
        public static void Seed(IApplicationBuilder applicationBulider)
        {
            using (var serviceScope = applicationBulider.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(new List<Category>()

                    {
                        new Category()
                        {
                            Icon = "/images/cloud-solid.svg",
                            Description = "shadow lover",
                        },
                          new Category()
                        {
                            Icon = "/images/sun-solid.svg",
                            Description = "sun lover",
                        },
                            new Category()
                        {
                            Icon = "/images/paw-solid.svg",
                            Description = "animal lover",
                        },
                              new Category()
                        {
                            Icon = "/images/infinity-solid.svg",
                            Description = "immortals",
                        },
                                      new Category()
                        {
                            Icon = "/images/skull-solid.svg",
                            Description = "deathly",
                        }
                    });
                    context.SaveChanges();

                }
                if (!context.Plants.Any())
                {
                    context.Plants.AddRange(new List<Plant>()

                    {
                        new Plant()
                        {
                            Name = "Monstera deliciosa",
                            Description = "Monstera deliciosa, commonly called split-leaf philodendron or swiss cheese plant, is native to Central America. It is a climbing, evergreen perennial vine that is perhaps most noted for its large perforated leaves on thick plant stems and its long cord-like aerial roots.<\br> Problems <\br> Watch for aphids, mealybugs, thrips, scale or spider mites.<\br>  Uses <\br> Large leaved indoor plant for warm, bright and humid areas.",
                            ImageURL = "https://a.allegroimg.com/original/114271/2526d6e84ba09998b0f6ab05059f/Ladna-Monstera-Deliciosa-Dziurawa-Filodendron",
                            Quantity = 2,
                            Price = 30.99
                        }
                    });
                    context.SaveChanges();

                }

                //PLANTS WITH CATEGORIES
                if (!context.Plants_Categories.Any())
                {
                    context.Plants_Categories.AddRange(new List<Plant_Category>()

                    {
                    new Plant_Category()
                    {
                        PlantId = 1,
                        CategoryId = 4
                    },

                       new Plant_Category()

                       {
                           PlantId = 1,
                           CategoryId = 2
                       } });
                    context.SaveChanges();

                }


            }
        }
    }
}

