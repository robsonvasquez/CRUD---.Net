using Microsoft.EntityFrameworkCore;

namespace teste.Models
{
    class DBContext : DbContext
    {
        public DbSet<Client> Client { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Buy> Buy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=teste.db");
        }
    }
}
