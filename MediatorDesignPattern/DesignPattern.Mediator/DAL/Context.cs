using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =YDYO-HP\\SQLEXPRESS; Database=DesignPattern8;Integrated Security=True;");
        }
        public DbSet<Product> Products { get; set; }
    }
}
