using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CINEMA_DB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CINEMA_DB.Pages.FilReq.Filter
{
    public class FilterDateModel : PageModel
    {
        private readonly CINEMA_DB.Data.CINEMA_DBContext _context;
        public FilterDateModel(CINEMA_DB.Data.CINEMA_DBContext context)
        {

            _context = context;
        }
        public IList<Repertoire>  Repertoire { get; set; }
        public async Task<IActionResult> OnGetAsync(DateTime? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Repertoire = _context.Repertoire.Where(r => r.Date.Date == id.Value.Date).ToList();
            return Page();
        }
    }
}
