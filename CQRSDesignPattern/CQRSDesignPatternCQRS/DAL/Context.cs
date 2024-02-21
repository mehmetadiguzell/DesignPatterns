using Microsoft.EntityFrameworkCore;

namespace CQRSDesignPatternCQRS.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =YDYO-HP\\SQLEXPRESS; Database=DesignPattern2;Integrated Security=True;");
        }
        public DbSet<Product> Products { get; set; }
    }
}
