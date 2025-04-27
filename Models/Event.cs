using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner.Models
{
    public class Event : BaseEntity
    {
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }

        public Event(string title, string location, DateTime date)
        {
            Title = title;
            Location = location;
            Date = date;
        }

        public Event()
        {
        }
    }
}
