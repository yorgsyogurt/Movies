using Movies.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Movies.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieDbContext(serviceProvider.GetRequiredService<DbContextOptions<MovieDbContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                   new Movie
                   {
                       Director = "Todd Phillips",
                       Genre = "Crime , Drama , Thriller",
                       Title = "Joker",
                       Poster = "Poster",
                       ReleaseDate = new DateTime(2019, 10, 3)
                   },
                    new Movie
                    {
                        Director = "David Leitch",
                        Genre = "Action , Adventure",
                        Title = "Fast & Furious Presents: Hobbs & Shaw",
                        Poster = "Poster",
                        ReleaseDate = new DateTime(2019, 8, 2)
                    },
                    new Movie
                    {
                        Director = "Jon Favreau",
                        Genre = "Adventure , Animation , Drama , Family , Musical",
                        Title = "The Lion King",
                        Poster = "Poster",
                        ReleaseDate = new DateTime(2019, 7, 19)
                    },
                    new Movie
                    {
                        Director = "Joachim Rønning",
                        Genre = "Adventure , Family , Fantasy",
                        Title = "Maleficent: Mistress of Evil",
                        Poster = "Poster",
                        ReleaseDate = new DateTime(2019, 10, 18)
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
