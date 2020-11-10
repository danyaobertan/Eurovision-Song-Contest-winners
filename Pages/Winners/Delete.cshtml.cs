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
    public class DeleteModel : PageModel
    {
        private readonly EUMusic.Data.EUMusicContext _context;

        public DeleteModel(EUMusic.Data.EUMusicContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Winner = await _context.Winner.FindAsync(id);

            if (Winner != null)
            {
                _context.Winner.Remove(Winner);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
