using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CINEMA_DB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CINEMA_DB.Pages.FilReq.Filter
{
    public class FilterGenreModel : PageModel
    {
        private readonly CINEMA_DB.Data.CINEMA_DBContext _context;
        public FilterGenreModel(CINEMA_DB.Data.CINEMA_DBContext context)
        {

            _context = context;
        }
        public Genre Genre { get; set; }
        public IList<Film> Film { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Genre = _context.Genre.First(p => p.ID == id);
            if (Genre == null)
            {
                return NotFound();
            }
            Film = _context.Film.Where(p => p.GenreID == id).ToList();
            return Page();
        }
    }
}
