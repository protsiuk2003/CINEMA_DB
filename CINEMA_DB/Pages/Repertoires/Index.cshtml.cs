﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly CINEMA_DB.Data.CINEMA_DBContext _context;

        public IndexModel(CINEMA_DB.Data.CINEMA_DBContext context)
        {
            _context = context;
        }

        public IList<Repertoire> Repertoire { get;set; }

        public async Task OnGetAsync()
        {
            Repertoire = await _context.Repertoire.ToListAsync();
        }
    }
}
