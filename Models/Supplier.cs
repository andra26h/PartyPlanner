using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner.Models
{
    public class Supplier : BaseEntity
    {
        public string Name { get; set; }
        public string Service { get; set; }
        public string Contact { get; set; }

        public Supplier(string name, string service, string contact)
        {
            Name = name;
            Service = service;
            Contact = contact;
        }

        public Supplier()
        {
        }
    }
}
