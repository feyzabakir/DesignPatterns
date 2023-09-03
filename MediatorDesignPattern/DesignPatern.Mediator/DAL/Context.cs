using Microsoft.EntityFrameworkCore;

namespace DesignPatern.Mediator.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=LAPTOP-4OD0B581;initial catalog=DesignPattern8; integrated security=true;");

        }
        public DbSet<Product> Products { get; set; }

    }
}
