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
        public DbSet<Customer> customers { get; set; }
        public DbSet<Membershiptype> membershiptypes { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
            string GenreJSon = System.IO.File.ReadAllText("JSONdata/Genres.json");
            List<Genre>? genres = System.Text.Json.
            JsonSerializer.Deserialize<List<Genre>>(GenreJSon);
            //Seed to genres
            foreach (Genre c in genres)
                model.Entity<Genre>()
                .HasData(c);

            string MovieJson = System.IO.File.ReadAllText("JSONdata/Movies.json");
            List<Movie>? movies = System.Text.Json.
            JsonSerializer.Deserialize<List<Movie>>(MovieJson);
            //Seed to movies
            foreach (Movie c in movies)
                model.Entity<Movie>()
                .HasData(c);
        }
    }
}
