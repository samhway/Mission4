using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {

        }

        public DbSet<MovieResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(

                new MovieResponse
                {
                    MovieId = 1,
                    Category = "Sci-Fi",
                    Title = "Dune",
                    Director = "Denis Villaneuve",
                    Year = 2021,
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "Does the book justice"
                },
                new MovieResponse
                {
                    MovieId = 2,
                    Category = "Sports",
                    Title = "Moneyball",
                    Director = "Bennett Miller",
                    Year = 2011,
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "Jonah Hill's best work"
                },
                new MovieResponse
                {
                    MovieId = 3,
                    Category = "Comedy", 
                    Title = "The Other Guys",
                    Director = "Adam McKay",
                    Year = 2010,
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "Funny movie"
                });
        }
    }
}
