using AudioExchange_Data.Domain;
using Microsoft.EntityFrameworkCore;

namespace AudioExchange_Data.Data
{
    class AudioExchangeContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //for testing or demo you can add the connection string here, change to injectable for production
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=AudioExchange");
        }
    }
}
