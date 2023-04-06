using Microsoft.EntityFrameworkCore;

namespace MVC_CoreIdentity.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {
            
        }

        public DbSet<Trainee> Trainee { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}
