using PartyPlanner.Models;
using PartyPlanner.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using PartyPlanner.Data;

namespace PartyPlanner.Repositories.Implementations
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly PartyPlannerContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(PartyPlannerContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>(); 
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity); 
            _context.SaveChanges(); 
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity); 
            _context.SaveChanges(); 
        }

        public void Delete(int id)
        {
            var entity = _dbSet.FirstOrDefault(e => e.Id == id); 
            if (entity != null)
            {
                _dbSet.Remove(entity); 
                _context.SaveChanges(); 
            }
        }

        public T GetById(int id)
        {
            return _dbSet.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList(); 
        }
    }
}
