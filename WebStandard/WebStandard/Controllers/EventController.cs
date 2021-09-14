using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStandard.Models;

namespace WebStandard.Controllers
{
    [Route("AllEvents")] 
    public class EventController : Controller
    {

        private readonly ApplicationDbContext apiContext;

        public EventController(ApplicationDbContext apiContext)
        {
            this.apiContext = apiContext;
        }

        // On url "AllEvents we get all events from 'database'. We return the view with all events." 
        public IActionResult AllEvents()
        {
            List<Event> events = apiContext.GetEvents();
            return View(events);
        }


        // On url "AllEvents/EventData/{id}" we get a info about the clicked event. We get the event by the id. 
        // We return the view with the event.
        [Route("EventData/{id}")]
        public IActionResult EventData(int id)
        {
            Event gettedEvent = apiContext.GetEventById(id);
            return View(gettedEvent);
        }
    }
}

