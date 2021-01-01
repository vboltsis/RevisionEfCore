using EntityFExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFExample
{
    class ButcherContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        //fluent api
        /*protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Customer>()
                .Property(b => b.FirstName)
                .HasMaxLength(50);

            builder.Entity<Customer>()
                .Property(b => b.LastName)
                .HasMaxLength(50);
        }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string
            optionsBuilder.UseSqlServer(@"Server=.;Database=ButcherDb;Trusted_Connection=True;");
        }
    }
}
