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
    public class LFiModel : PageModel
    {
        private readonly CINEMA_DB.Data.CINEMA_DBContext _context;

        public LFiModel(CINEMA_DB.Data.CINEMA_DBContext context)
        {
            _context = context;
        }
        public IList<Genre> Genre { get; set; }
        public IList<Film> Film { get; set; }
        public async Task OnGetAsync()
        {
            Genre = await _context.Genre.ToListAsync();
            Film = await _context.Film.ToListAsync();
        }
    }
}
