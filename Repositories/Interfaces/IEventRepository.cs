using PartyPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner.Repositories.Interfaces
{
    public interface IEventRepository
    {
        void Add(Event eventItem);
        IEnumerable<Event> GetAll();
        Event GetById(int id);
        void Update(Event eventItem);
        void Delete(int id);
    }
}
