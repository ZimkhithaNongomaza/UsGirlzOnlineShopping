using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
namespace OnlineShopping2.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Flare Leg",
                        Category = "Bottoms",
                        Price = 151

                    },
                    new Product
                    {
                        Name = "Floral Print",
                        Category = "Dresses",
                        Price = 88




                    },
                    new Product
                    {
                        Name = "Hair Bonnet",
                        Category = "Accessories",
                        Price = 24

                    },
                    new Product
                    {
                        Name = "High Bikini",
                        Category = "Beachwear",
                        Price = 190

                    },
                    new Product
                    {
                        Name = "Floral Cross Slides",
                        Category = "Shoes",
                        Price = 78

                    },

                    new Product
                    {
                        Name = "Pink Quartz Watch",
                        Category = "Jewellery",
                        Price = 62

                    },
                    new Product
                    {
                        Name = "Bandama Cami Top",
                        Category = "Tank Tops",
                        Price = 42
                    },
                    new Product
                    {
                        Name = "Chain Flap Square Bag",
                        Category = "Bags",
                        Price = 54

                    }
);
                //context.SaveChanges();

                if (!context.Employees.Any())
                {
                    context.Employees.AddRange(
                        new Employee
                        {
                            Name = "Zimkhitha",
                            Surname = "Nongomaza",
                            Gender = "Female",
                            GradeLevel = 5

                        },
                        new Employee
                        {
                            Name = "Lupho",
                            Surname = "Nongomaza",
                            Gender = "Male",
                            GradeLevel = 3
                        }
                       ); ;
                    context.SaveChanges();
                }
            }
        }
    }
}
