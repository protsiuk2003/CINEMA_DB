using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CINEMA_DB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CINEMA_DB.Pages.FilReq.Request
{
    public class PerDepModel : PageModel
    {
        private readonly CINEMA_DB.Data.CINEMA_DBContext _context;

        public PerDepModel(CINEMA_DB.Data.CINEMA_DBContext context)
        {
            _context = context;
        }
        public IList<Position> Position { get; set; }
        public IList<Staff> Staff { get; set; }
        public async Task OnGetAsync()
        {
            Position = await _context.Position.ToListAsync();
            Staff = await _context.Staff.ToListAsync();
        }
    }
}
