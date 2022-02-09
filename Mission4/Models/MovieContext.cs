using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MovieContext : DbContext 
    {
        public MovieContext (DbContextOptions<MovieContext> options) : base(options)
        {
            // leave blank for now
        }

        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    MovieId = 1,
                    Category = "Romance",
                    Title = "Valley Girl",
                    Year = 1983,
                    Director = "Martha Coolidge",
                    Rating = "R",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new ApplicationResponse
                {
                    MovieId = 2,
                    Category = "Romance",
                    Title = "Amelie",
                    Year = 2001,
                    Director = "Jean-Pierre Jeunet",
                    Rating = "R",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new ApplicationResponse
                {
                    MovieId = 3,
                    Category = "Romance",
                    Title = "Call Me by Your Name",
                    Year = 2017,
                    Director = "Luca Guadagnino",
                    Rating = "R",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }
                );
        }
    }
}
