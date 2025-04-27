using PartyPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner.Repositories.Interfaces
{
    public interface IGuestRepository
    {
        void Add(Guest guest);
        IEnumerable<Guest> GetAll();
        Guest GetById(int id);
        void Update(Guest guest);
        void Delete(int id);
    }
}
