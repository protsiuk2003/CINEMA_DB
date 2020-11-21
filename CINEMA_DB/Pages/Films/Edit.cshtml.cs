using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CINEMA_DB.Data;
using CINEMA_DB.Models;

namespace CINEMA_DB.Pages.Films
{
    public class EditModel : PageModel
    {
        private readonly CINEMA_DB.Data.CINEMA_DBContext _context;

        public EditModel(CINEMA_DB.Data.CINEMA_DBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Film Film { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Film = await _context.Film.FirstOrDefaultAsync(m => m.ID == id);

            if (Film == null)
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

            _context.Attach(Film).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmExists(Film.ID))
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

        private bool FilmExists(long id)
        {
            return _context.Film.Any(e => e.ID == id);
        }
    }
}
