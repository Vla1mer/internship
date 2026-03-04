using Microsoft.EntityFrameworkCore;

namespace internship
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Add your DbSet<> properties here when you have entities
        // public DbSet<YourEntity> YourEntities { get; set; }
    }
}
