using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Post> Post => Set<Post>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // key config + seed data
        }

    }
}
