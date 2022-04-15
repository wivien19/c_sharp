using BlackFridayWeb.Models;
using Microsoft.EntityFrameworkCore;


namespace BlackFridayWeb.Context
{
    public class EFContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=.//DB//blackfriday.db");
        }
    }
}
