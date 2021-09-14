using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


namespace WebStandard.Models
{
    public class Event
    {
        // Event id 
        [Key]
        public int Id { get; set; }

        // Event name
        public string Name { get; set; }

        // Event description
        public string Description { get; set; }

        // Event starting date
        public DateTime StartDate { get; set; }

        // Event ending date
        public DateTime? EndDate { get; set; }
    }
}
