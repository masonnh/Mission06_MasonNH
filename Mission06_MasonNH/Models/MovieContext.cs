using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_MasonNH.Models
{
    public class MovieContext : DbContext
    {
        // Constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            // Leave blank for now. We are inheriting
        }

        public DbSet<Movie> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    category = "Comedy",
                    title = "Hot Rod",
                    year = 2007,
                    director = "Akiva Schaffer",
                    rating = "PG-13"
                },
                new Movie
                {
                    MovieId = 2,
                    category = "Family",
                    title = "Megamind",
                    year = 2010,
                    director = "Tom McGrath",
                    rating = "PG"
                },
                new Movie
                {
                    MovieId = 3,
                    category = "Family",
                    title = "The Incredibles",
                    year = 2004,
                    director = "Brad Bird",
                    rating = "PG"
                }
            );
        }
    }
}
