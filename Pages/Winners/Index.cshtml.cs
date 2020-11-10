using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EUMusic.Data;
using EUMusic.Models;

namespace EUMusic.Pages.Winners
{
    public class IndexModel : PageModel
    {
        private readonly EUMusic.Data.EUMusicContext _context;

        public IndexModel(EUMusic.Data.EUMusicContext context)
        {
            _context = context;
        }

        public IList<Winner> Winner { get;set; }

        public async Task OnGetAsync()
        {
            Winner = await _context.Winner.ToListAsync();
        }
    }
}
