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

        public DbSet<Movie> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        // seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Comedy"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Family"
                }
            );

            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    CategoryId = 1,
                    title = "Hot Rod",
                    year = 2007,
                    director = "Akiva Schaffer",
                    rating = "PG-13"
                },
                new Movie
                {
                    MovieId = 2,
                    CategoryId = 2,
                    title = "Megamind",
                    year = 2010,
                    director = "Tom McGrath",
                    rating = "PG"
                },
                new Movie
                {
                    MovieId = 3,
                    CategoryId = 2,
                    title = "The Incredibles",
                    year = 2004,
                    director = "Brad Bird",
                    rating = "PG"
                }
            );
        }
    }
}
