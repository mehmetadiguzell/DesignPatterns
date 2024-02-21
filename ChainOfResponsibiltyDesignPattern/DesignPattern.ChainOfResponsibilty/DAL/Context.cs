using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibilty.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =YDYO-HP\\SQLEXPRESS; Database=DesignPatterm1;Integrated Security=True;");
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
