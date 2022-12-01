using Microsoft.EntityFrameworkCore;
using MoviePage.Data;

namespace MoviePage.Models
{
    public static class SeedData
    {
        public static void Initailize(IServiceProvider serviceProvider)
        {
            using (var context = new MoviePageContext (
                serviceProvider.GetRequiredService<DbContextOptions<MoviePageContext>>()))
            {
                if(context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null MoviePageContext");
                }
                if (context.Movie.Any())
                {
                    return;
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R"

                    },
                    new Movie
                    {
                        Title = "Ghostbusters",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = " Comedy",
                        Price = 8.99M,
                        Rating = "B"

                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1991-4-16"),
                        Genre = "Comedy",
                        Price = 3.99M,
                        Rating = "A"

                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-6-24"),
                        Genre = "Western",
                        Price = 7.99M,
                        Rating = "H"

                    }
                );
                context.SaveChanges();
            }

        }
    }
}
