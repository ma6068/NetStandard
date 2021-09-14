using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStandard.Models;

namespace WebStandard
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any event.
                if (context.Events.Any())
                {
                    return;   // Data was already seeded
                }

                context.Events.AddRange(
                    new Event
                    {
                        Id = 1,
                        Name = "Programing homework",
                        Description = "Doing some project in C#.",
                        StartDate = Convert.ToDateTime((2021, 12, 15)),
                        EndDate = Convert.ToDateTime((2021, 12, 25))
                    },
                    new Event
                    {
                        Id = 2,
                        Name = "My birthday",
                        Description = "Party at home!!!",
                        StartDate = Convert.ToDateTime((2021, 11, 24)),
                        EndDate = Convert.ToDateTime((2012, 11, 25))
                    },
                    new Event
                    {
                        Id = 3,
                        Name = "Dinner with friends",
                        Description = "Going in some coom restoraunt with my best friends.",
                        StartDate = Convert.ToDateTime((2021, 9, 20)),
                        EndDate = Convert.ToDateTime((2012, 9, 21))
                    });

                context.SaveChanges();
            }
        }
    }
}
