using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EUMusic.Data;
using System;
using System.Linq;

namespace EUMusic.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EUMusicContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EUMusicContext>>()))
            {
                // Look for any movies.
                if (context.Winner.Any())
                {
                    return;   // DB has been seeded
                }

                context.Winner.AddRange(
                  
                    new Winner
                    {
                        Date = DateTime.Parse("1956-5-24"),
                        HostCity = "Lugano",
                        WinnerCountry = "Switzerland",
                        SongTitle = "Refrain",
                        Performer = "Lys Assia",
                        Language = "French",
                        Points =0
                    },
                    new Winner
                    {
                        Date = DateTime.Parse("1957-3-3"),
                        HostCity = "Frankfurt",
                        WinnerCountry = "Netherlands",
                        SongTitle = "Net als toen",
                        Performer = "Corry Brokken",
                        Language = "Dutch",
                        Points = 31
                    },
                    new Winner
                    {
                        Date = DateTime.Parse("1958-3-12"),
                        HostCity = "Hilversum",
                        WinnerCountry = "France",
                        SongTitle = "Dors, mon amour",
                        Performer = "André Claveau",
                        Language = "French",
                        Points = 27
                    },
                    new Winner
                    {
                        Date = DateTime.Parse("1959-3-11"),
                        HostCity = "Cannes",
                        WinnerCountry = "Netherlands",
                        SongTitle = "Een beetje",
                        Performer = "Teddy Scholten",
                        Language = "Dutch",
                        Points = 21
                    },
                    new Winner
                    {
                        Date = DateTime.Parse("1960-3-29"),
                        HostCity = "London",
                        WinnerCountry = "France",
                        SongTitle = "Tom Pillibi",
                        Performer = "Jacqueline Boyer",
                        Language = "French",
                        Points = 32
                    },
                    new Winner
                    {
                        Date = DateTime.Parse("1961-3-18"),
                        HostCity = "Cannes",
                        WinnerCountry = "Luxembourg",
                        SongTitle = "Nous les amoureux",
                        Performer = "Jean-Claude Pascal",
                        Language = "French",
                        Points = 31
                    },
                    new Winner
                    {
                        Date = DateTime.Parse("1962-3-18"),
                        HostCity = "Luxembourg",
                        WinnerCountry = "France",
                        SongTitle = "Un premier amour",
                        Performer = "Isabelle Aubret",
                        Language = "French",
                        Points = 26
                    }



                );
                context.SaveChanges();
            }
        }
    }
}
