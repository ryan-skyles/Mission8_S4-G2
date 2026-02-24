using Microsoft.EntityFrameworkCore;

namespace Mission9_S4_G2.Models
{
    public class QuadrantsContext : DbContext
    {
        public QuadrantsContext(DbContextOptions<QuadrantsContext> options) : base(options)
        {

        }

        public DbSet<Task> Tasks { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
