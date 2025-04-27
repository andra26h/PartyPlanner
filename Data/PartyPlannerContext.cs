using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PartyPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner.Data
{
    public class PartyPlannerContext : DbContext
    {
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<PlanningTask> Tasks { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-VV03FU7\SQLEXPRESSA;Database=PartyPlannerDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
