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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Sci-Fi"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Sports"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Drama"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Documentary"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Comedy"
                },
                new Category
                {
                    CategoryID = 6,
                    CategoryName = "Family"
                });

            mb.Entity<MovieResponse>().HasData(

                new MovieResponse
                {
                    MovieId = 1,
                    CategoryID = 1,
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
                    CategoryID = 2,
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
                    CategoryID = 3, 
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
