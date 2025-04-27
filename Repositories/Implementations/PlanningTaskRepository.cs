using PartyPlanner.Data;
using PartyPlanner.Models;
using PartyPlanner.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner.Repositories.Implementations
{
    public class PlanningTaskRepository : IPlanningTaskRepository
    {
        private readonly PartyPlannerContext _context;

        public PlanningTaskRepository(PartyPlannerContext context)
        {
            _context = context;
        }

        public void Add(PlanningTask planningTask)
        {
            _context.Tasks.Add(planningTask);
            _context.SaveChanges();
        }

        public IEnumerable<PlanningTask> GetAll()
        {
            return _context.Tasks.ToList();
        }

        public PlanningTask GetById(int id)
        {
            return _context.Tasks.Find(id);
        }

        public void Update(PlanningTask planningTask)
        {
            _context.Tasks.Update(planningTask);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var planningTask = _context.Tasks.Find(id);
            if (planningTask != null)
            {
                _context.Tasks.Remove(planningTask);
                _context.SaveChanges();
            }
        }
    }
}
