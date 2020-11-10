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
    public class DetailsModel : PageModel
    {
        private readonly EUMusic.Data.EUMusicContext _context;

        public DetailsModel(EUMusic.Data.EUMusicContext context)
        {
            _context = context;
        }

        public Winner Winner { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Winner = await _context.Winner.FirstOrDefaultAsync(m => m.ID == id);

            if (Winner == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
