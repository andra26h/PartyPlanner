using PartyPlanner.Data;
using PartyPlanner.Models;
using PartyPlanner.Repositories.Implementations;
using PartyPlanner.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner.Repositories
{
    public class ServiceFactory
    {
        private readonly PartyPlannerContext _context;

        public ServiceFactory()
        {
            // Crearea unei instanțe a PartyPlannerContext
            _context = new PartyPlannerContext();
        }

        // Fabrica pentru crearea repository-urilor generice
        public IRepository<T> CreateRepository<T>() where T : BaseEntity
        {
            return new GenericRepository<T>(_context);
        }
    }
}
