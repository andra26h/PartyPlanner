using PartyPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner.Repositories.Interfaces
{
    public interface ISupplierRepository
    {
        void Add(Supplier supplier);
        IEnumerable<Supplier> GetAll();
        Supplier GetById(int id);
        void Update(Supplier supplier);
        void Delete(int id);
    }
}
