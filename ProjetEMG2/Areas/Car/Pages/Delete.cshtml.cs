using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetEMG2.Data;
using ProjetEMG2.Models;

namespace ProjetEMG2.Areas.Car.Pages
{
    [Authorize(Roles = "Administrator")]
    public class DeleteModel : PageModel
    {
        private readonly ProjetEMG2.Data.ApplicationDbContext _context;

        public DeleteModel(ProjetEMG2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProjetEMG2.Models.Car Car { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars.FirstOrDefaultAsync(m => m.CodeVIN == id);

            if (car == null)
            {
                return NotFound();
            }
            else
            {
                Car = car;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars.FindAsync(id);
            if (car != null)
            {
                Car = car;
                _context.Cars.Remove(Car);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
