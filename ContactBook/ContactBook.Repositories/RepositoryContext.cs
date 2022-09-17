using ContactBook.Repositories.Items;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Repositories
{
    public class RepositoryContext : DbContext, IRepositoryContext
    {
        private readonly string _conectionString;

        public DbSet<ContactItem> ContactItems { get; set; }

        public RepositoryContext(string conectionString)
        {
            _conectionString = conectionString;

            Database.EnsureCreated();

            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_conectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ContactItem).Assembly);
        }
    }
}
