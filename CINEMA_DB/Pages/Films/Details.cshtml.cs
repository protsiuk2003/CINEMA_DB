using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CINEMA_DB.Data;
using CINEMA_DB.Models;

namespace CINEMA_DB.Pages.Films
{
    public class DetailsModel : PageModel
    {
        private readonly CINEMA_DB.Data.CINEMA_DBContext _context;

        public DetailsModel(CINEMA_DB.Data.CINEMA_DBContext context)
        {
            _context = context;
        }

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
    }
}
