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
        public SelectList ContestWinners { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ContestWinner { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            //IQueryable<string> winnerQuery = ((from m in _context.Winner
            //                                orderby m.WinnerCountry
            //                                select m.WinnerCountry).Distinct());

            IQueryable<string> winnerQuery = ((from m in _context.Winner
                                               orderby m.WinnerCountry
                                               select m.WinnerCountry).Distinct());

            var winners = from m in _context.Winner
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                winners = winners.Where(s => s.Performer.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(ContestWinner))
            {
                winners = winners.Where(x => x.WinnerCountry == ContestWinner);
            }
            //ContestWinner = Winners
            ContestWinners = new SelectList(await winnerQuery.ToListAsync());
            Winner = await winners.ToListAsync();
        }

    }
}
