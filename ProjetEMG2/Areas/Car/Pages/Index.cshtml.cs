using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetEMG2.Data;
using ProjetEMG2.Models;

namespace ProjetEMG2.Areas.Car.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ProjetEMG2.Data.ApplicationDbContext _context;

        public IndexModel(ProjetEMG2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ProjetEMG2.Models.Car> Car { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Car = await _context.Cars.ToListAsync();
        }
    }
}
