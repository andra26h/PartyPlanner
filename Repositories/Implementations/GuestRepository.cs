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
    public class GuestRepository : IGuestRepository
    {
        private readonly PartyPlannerContext _context;

        public GuestRepository(PartyPlannerContext context)
        {
            _context = context;
        }

        public void Add(Guest guest)
        {
            _context.Guests.Add(guest);
            _context.SaveChanges();
        }

        public IEnumerable<Guest> GetAll()
        {
            return _context.Guests.ToList();
        }

        public Guest GetById(int id)
        {
            return _context.Guests.Find(id);
        }

        public void Update(Guest guest)
        {
            _context.Guests.Update(guest);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var guest = _context.Guests.Find(id);
            if (guest != null)
            {
                _context.Guests.Remove(guest);
                _context.SaveChanges();
            }
        }
    }
}
