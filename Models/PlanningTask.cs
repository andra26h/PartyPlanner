using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner.Models
{
    public class PlanningTask : BaseEntity
    {
        public string Description { get; set; }
        public string AssignedTo { get; set; }
        public bool Done { get; set; }

        public PlanningTask(string description, string assignedTo, bool done)
        {
            Description = description;
            AssignedTo = assignedTo;
            Done = done;
        }

        public PlanningTask()
        {
        }
    }
}
