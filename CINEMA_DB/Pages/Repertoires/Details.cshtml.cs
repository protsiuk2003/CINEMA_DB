using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CINEMA_DB.Data;
using CINEMA_DB.Models;

namespace CINEMA_DB.Pages.Repertoires
{
    public class DetailsModel : PageModel
    {
        private readonly CINEMA_DB.Data.CINEMA_DBContext _context;

        public DetailsModel(CINEMA_DB.Data.CINEMA_DBContext context)
        {
            _context = context;
        }

        public Repertoire Repertoire { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Repertoire = await _context.Repertoire.FirstOrDefaultAsync(m => m.ID == id);

            if (Repertoire == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
