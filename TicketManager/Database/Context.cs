using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManager.Models;

namespace TicketManager.Database
{
    public class Context : DbContext
    {
        public DbSet<DbEmployee> Employees { get; set; }

        public DbSet<DbTicket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString:
               "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres;");
            base.OnConfiguring(optionsBuilder);
        }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries()
                           .Where(o => o.Entity is Base && (o.State == EntityState.Added || o.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                var now = DateTime.UtcNow;

                if (entity.State == EntityState.Added)
                {
                    ((Base)entity.Entity).created_at = now;
                }
                 ((Base)entity.Entity).updated_at = now;
            }
        }
    }
}
