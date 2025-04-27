// Repositories/ServiceFactory.cs
using PartyPlanner.Data;
using PartyPlanner.Repositories.Interfaces;
using PartyPlanner.Repositories.Implementations;

namespace PartyPlanner.Repositories
{
    public class ServiceFactory
    {
        private readonly PartyPlannerContext _context;

        public ServiceFactory(PartyPlannerContext context)
        {
            _context = context;
        }

        public IGuestRepository CreateGuestRepository() => new GuestRepository(_context);
        public IEventRepository CreateEventRepository() => new EventRepository(_context);
        public IPlanningTaskRepository CreatePlanningTaskRepository() => new PlanningTaskRepository(_context);
        public ISupplierRepository CreateSupplierRepository() => new SupplierRepository(_context);
    }
}
