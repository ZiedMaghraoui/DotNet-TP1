using Microsoft.EntityFrameworkCore;

namespace DotNet_TP1.Models
{
    public class ApplicationdbContext : DbContext
    {
        public ApplicationdbContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Movie>? movies { get; set; }
        public DbSet<Genre> genres { get; set; }
    }
}
