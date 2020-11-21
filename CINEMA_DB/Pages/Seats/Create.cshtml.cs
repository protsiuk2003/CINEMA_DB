using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CINEMA_DB.Data;
using CINEMA_DB.Models;

namespace CINEMA_DB.Pages.Seats
{
    public class CreateModel : PageModel
    {
        private readonly CINEMA_DB.Data.CINEMA_DBContext _context;

        public CreateModel(CINEMA_DB.Data.CINEMA_DBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Seat Seat { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Seat.Add(Seat);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
