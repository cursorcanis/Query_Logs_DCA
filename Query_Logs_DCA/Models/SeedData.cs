using Microsoft.EntityFrameworkCore;
using Query_Logs_DCA.Data;

namespace Query_Logs_DCA.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Query_Logs_DCAContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Query_Logs_DCAContext>>()))
            {
                if (context == null || context.Query == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Query.Any())
                {
                    return;   // DB has been seeded
                }

                context.Query.AddRange(
                    new Query
                    {
                        Title_of_Query = "When Users cannot be located",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Category_of_Query = "Searching for fields",
                        Rating_Complexity = "Moderate"
                        //Price = 7.99M
                    },

                    new Query
                    {
                        Title_of_Query = "Ghost in the machines Query ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Category_of_Query = "Comedy of SQL Errors",
                        Rating_Complexity = "High Complexity"
                        //Price = 8.99M
                    },

                    new Query
                    {
                        Title_of_Query = "Machine crusaders in fields",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Category_of_Query = "Schema updater",
                        Rating_Complexity = "Low"
                        //Price = 9.99M
                    },

                    new Query
                    {
                        Title_of_Query = "Rio of Queries",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Category_of_Query = "Whole Schema",
                        Rating_Complexity = "Medium difficulty"
                        //Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
