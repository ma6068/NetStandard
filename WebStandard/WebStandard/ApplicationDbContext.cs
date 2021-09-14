using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebStandard.Models;

namespace WebStandard
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Event> Events { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            LoadEvents();
        }

        // Function that add some events in our 'database'
        public void LoadEvents()
        {
            Event event1 = new Event() 
            {
                Id = 1,
                Name = "Project in C#",
                Description = "This is a project in C#, but we do not have much time to do it." +
                    " We have to get organized and finish it quickly." +
                    " We need to create an application for events.",
                StartDate = DateTime.Parse("2021-09-10"),
                EndDate = DateTime.Parse("2021-09-12"),
            };
            Events.Add(event1);

            Event event2 = new Event()
            {
                Id = 2,
                Name = "My birthday",
                Description = "Party at home!!! " +
                    "I was planning to invite my friends and colleagues to celebrate my birthday. " +
                    "I hope the party will be great because all the people are very positive.",
                StartDate = DateTime.Parse("2021-11-24"),
                EndDate = DateTime.Parse("2021-11-25"),
            };
            Events.Add(event2);

            Event event3 = new Event() 
            {
                Id = 3,
                Name = "Dinner with business partners.",
                Description = "An important dinner with my business partners." +
                    "I was planning to go to the most famous seafood restaurant in town. " +
                    "I hope she likes it. We have to agree on what the new project in our company will look like.",
                StartDate = DateTime.Parse("2021-12-15"),
                EndDate = null,
            };
            Events.Add(event3);

            Event event4 = new Event()
            {
                Id = 4,
                Name = "Team building travel",
                Description = "We want to make a longer vacation with the team. We want to visit Spain and Portugal." +
                    "Then we will go to South America (Brazil and Argentina)." +
                    "I think they have a similar culture.",
                StartDate = DateTime.Parse("2021-11-05"),
                EndDate = DateTime.Parse("2021-12-07"),
            };
            Events.Add(event4);
        }

        // GET all events with their data from 'database'
        public List<Event> GetEvents()
        {
            return Events.Local.ToList<Event>();
        }


        // GET element (event) by id from 'database'. 
        public Event GetEventById(int id) 
        {
            return this.Events.Local.FirstOrDefault(e => e.Id == id);
        }
    }
}
