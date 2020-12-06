using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CINEMA_DB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CINEMA_DB.Pages.FilReq.Filter
{
    public class FilterOccupancyModel : PageModel
    {
        private readonly CINEMA_DB.Data.CINEMA_DBContext _context;
        public FilterOccupancyModel(CINEMA_DB.Data.CINEMA_DBContext context)
        {

            _context = context;
        }
        public IList<Seat> Seat { get; set; }
        //public IList<Repertoire> Repertoire { get; set; }
        public async Task<IActionResult> OnGetAsync(bool? Occup)
        {
            if (Occup == null)
            {
                return NotFound();
            }
            Seat = _context.Seat.Where(p => p.Occupancy == Occup).ToList();
            //Film = _context.Film.Where(p => p.GenreID == id).ToList();
            return Page();
        }
    }
}
