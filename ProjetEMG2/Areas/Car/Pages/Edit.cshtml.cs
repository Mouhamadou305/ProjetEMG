using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetEMG2.Data;
using ProjetEMG2.Models;

namespace ProjetEMG2.Areas.Car.Pages
{
    [Authorize(Roles = "Administrator")]
    public class EditModel : PageModel
    {
        private readonly ProjetEMG2.Data.ApplicationDbContext _context;

        public EditModel(ProjetEMG2.Data.ApplicationDbContext context)
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

            var car =  await _context.Cars.FirstOrDefaultAsync(m => m.CodeVIN == id);
            if (car == null)
            {
                return NotFound();
            }
            Car = car;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Car).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarExists(Car.CodeVIN))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CarExists(string id)
        {
            return _context.Cars.Any(e => e.CodeVIN == id);
        }
    }
}
