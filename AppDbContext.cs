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
        private readonly IConfiguration _configuration;
        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Optional: Override OnConfiguring for design-time support
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
        }
    }
}
