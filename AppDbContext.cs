using Microsoft.EntityFrameworkCore;
using TeamApi.Models;

namespace TeamApi
{
    public class AppDbContext : DbContext
    {
        public DbSet<TeamMember> TeamMembers { get; set; } = null!;
        public DbSet<Hobby> Hobbies { get; set; } = null!;
        public DbSet<BreakfastFood> BreakfastFoods { get; set; } = null !;
        public DbSet<Books>? Books { get; set; }= null!;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Optional: Override OnConfiguring for design-time support
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TeamApiDb;Trusted_Connection=True;");
            }
        }
    }
}
