using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CINEMA_DB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CINEMA_DB.Pages.FilReq.Filter
{
    public class FilterPositionModel : PageModel
    {
        private readonly CINEMA_DB.Data.CINEMA_DBContext _context;
        public FilterPositionModel(CINEMA_DB.Data.CINEMA_DBContext context)
        {

            _context = context;
        }
        public Position Position { get; set; }
        public IList<Staff> Staff { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null){
                return NotFound();
            }
            Position = _context.Position.First(p => p.ID == id);
            if (Position == null)
            {
                return NotFound();
            }
            Staff = _context.Staff.Where(p => p.PositionID == id).ToList();
            return Page();
        }
    }
}
