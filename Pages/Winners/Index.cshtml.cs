using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EUMusic.Data;
using EUMusic.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList ContestWinner { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ContestWinners { get; set; }

        public async Task OnGetAsync()
        {
            var winners = from m in _context.Winner
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                winners = winners.Where(s => s.Performer.Contains(SearchString));
            }

            Winner = await winners.ToListAsync();
        }

    }
}
