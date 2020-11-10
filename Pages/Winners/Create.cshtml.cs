using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EUMusic.Data;
using EUMusic.Models;

namespace EUMusic.Pages.Winners
{
    public class CreateModel : PageModel
    {
        private readonly EUMusic.Data.EUMusicContext _context;

        public CreateModel(EUMusic.Data.EUMusicContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Winner Winner { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Winner.Add(Winner);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
