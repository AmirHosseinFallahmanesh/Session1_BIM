using Microsoft.EntityFrameworkCore;

namespace Demo1.Model
{
    public class MyContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Session1BIM;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Customer> Customers { get; set; }

    }
}
