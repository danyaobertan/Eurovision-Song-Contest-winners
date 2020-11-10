using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EUMusic.Data;
using EUMusic.Models;

namespace EUMusic.Pages.Winners
{
    public class EditModel : PageModel
    {
        private readonly EUMusic.Data.EUMusicContext _context;

        public EditModel(EUMusic.Data.EUMusicContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Winner).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WinnerExists(Winner.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool WinnerExists(int id)
        {
            return _context.Winner.Any(e => e.ID == id);
        }
    }
}
