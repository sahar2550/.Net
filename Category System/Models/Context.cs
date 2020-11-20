using Microsoft.EntityFrameworkCore;

namespace Category_System.Models
{
    public class Context : DbContext
    {
        public Context( DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
