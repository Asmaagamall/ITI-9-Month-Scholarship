using Microsoft.EntityFrameworkCore;

namespace MVC_Core2.Model
{
    public class ModelDbContext : DbContext
    {

        public ModelDbContext( DbContextOptions<ModelDbContext> options) :base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
