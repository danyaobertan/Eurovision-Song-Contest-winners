using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EUMusic.Models;

namespace EUMusic.Data
{
    public class EUMusicContext : DbContext
    {
        public EUMusicContext (DbContextOptions<EUMusicContext> options)
            : base(options)
        {
        }

        public DbSet<EUMusic.Models.Winner> Winner { get; set; }
    }
}
