using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CINEMA_DB.Pages.FilReq
{
    public class IndexModel : PageModel
    {
        private readonly CINEMA_DB.Data.CINEMA_DBContext _context;
        public IndexModel(CINEMA_DB.Data.CINEMA_DBContext context)
        {

            _context = context;
        }
        public IList<SelectListItem> SelPosition { get; set; }
        public IList<SelectListItem> SelGenres { get; set; }
        public IList<SelectListItem> SelOccupancy { get; set; }
        public void OnGet()
        {
            SelPosition = _context.Position.Select(p =>
                                  new SelectListItem
                                  {
                                      Value = p.ID.ToString(),
                                      Text = p.Name
                                  }).ToList();
            SelGenres = _context.Genre.Select(p =>
                                  new SelectListItem
                                  {
                                      Value = p.ID.ToString(),
                                      Text = p.Name
                                  }).ToList();
            SelOccupancy = new List<SelectListItem>
            {
                new SelectListItem { Value = "True", Text = "Занято" },
                new SelectListItem { Value = "False", Text = "Не занято" }
            };
        }
    }
}
