using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner.Models
{
    public class Guest : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool RSVP { get; set; }

        public Guest(string name, string email, bool rSVP)
        {
            Name = name;
            Email = email;
            RSVP = rSVP;
        }

        public Guest()
        {
        }
    }
}
