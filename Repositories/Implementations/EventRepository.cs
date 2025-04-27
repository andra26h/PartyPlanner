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
    public class EventRepository : IEventRepository
    {
        private readonly PartyPlannerContext _context;

        public EventRepository(PartyPlannerContext context)
        {
            _context = context;
        }

        public void Add(Event eventItem)
        {
            _context.Events.Add(eventItem);
            _context.SaveChanges();
        }

        public IEnumerable<Event> GetAll()
        {
            return _context.Events.ToList();
        }

        public Event GetById(int id)
        {
            return _context.Events.Find(id);
        }

        public void Update(Event eventItem)
        {
            _context.Events.Update(eventItem);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var eventItem = _context.Events.Find(id);
            if (eventItem != null)
            {
                _context.Events.Remove(eventItem);
                _context.SaveChanges();
            }
        }
    }
}
