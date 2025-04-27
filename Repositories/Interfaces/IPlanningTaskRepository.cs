using PartyPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner.Repositories.Interfaces
{
    public interface IPlanningTaskRepository
    {
        void Add(PlanningTask planningTask);
        IEnumerable<PlanningTask> GetAll();
        PlanningTask GetById(int id);
        void Update(PlanningTask planningTask);
        void Delete(int id);
    }
}
