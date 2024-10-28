using Microsoft.EntityFrameworkCore;
using Project_BookShop.Models;

namespace Project_BookShop
{
    public class BookDb_Context : DbContext
    {
        public BookDb_Context(DbContextOptions<BookDb_Context> options) : base(options)
        {
        }

        // Overriding OnConfiguring is not necessary if configuration is done in Program.cs.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Optional: Configure the database here if needed
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define model configurations here if necessary
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Login> Logins { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
