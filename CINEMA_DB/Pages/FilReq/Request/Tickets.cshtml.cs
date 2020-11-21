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
    public class TicketsModel : PageModel
    {
        private readonly CINEMA_DB.Data.CINEMA_DBContext _context;

        public TicketsModel(CINEMA_DB.Data.CINEMA_DBContext context)
        {
            _context = context;
        }
        public IList<Seat> Seat { get; set; }
        public IList<Repertoire> Repertoire { get; set; }
        public IList<Staff> Staff { get; set; }
        
        public async Task OnGetAsync()
        {
            Seat = await _context.Seat.ToListAsync();
            Staff = await _context.Staff.ToListAsync();
            Repertoire = await _context.Repertoire.ToListAsync();
            
        }
    }
}
