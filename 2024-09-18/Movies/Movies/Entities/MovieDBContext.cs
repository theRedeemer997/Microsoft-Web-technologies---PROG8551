using Microsoft.EntityFrameworkCore;

namespace Movies.Entities
{
    public class MovieDBContext:DbContext
    {
        public MovieDBContext(DbContextOptions<MovieDBContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }

        // (seeds) three movies with specific IDs, names, release years, and ratings into the database when the model is created
        // The HasData method is used to specify initial data that will be inserted into the database the first time it's created
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 1, Name = "Movie 1", Year = 1999, Rating = 5 },
                new Movie { MovieId = 2, Name = "Movie 2", Year = 1988, Rating = 5 },
                new Movie { MovieId = 3, Name = "Movie 3", Year = 1922, Rating = 5 });
        }
    }
}
