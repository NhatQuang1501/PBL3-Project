using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PBL3_Project.Data;
using PBL3_Project.Models;

namespace PBL3_Project.Pages.Admin.QLHSGS
{
    public class EditModel : PageModel
    {
        private readonly PBL3_Project.Data.PBL3_ProjectContext _context;

        public EditModel(PBL3_Project.Data.PBL3_ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HoSoGiaSu HoSoGiaSu { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.HoSoGiaSu == null)
            {
                return NotFound();
            }

            var hosogiasu =  await _context.HoSoGiaSu.FirstOrDefaultAsync(m => m.ID_GiaSu == id);
            if (hosogiasu == null)
            {
                return NotFound();
            }
            HoSoGiaSu = hosogiasu;
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

            _context.Attach(HoSoGiaSu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HoSoGiaSuExists(HoSoGiaSu.ID_GiaSu))
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

        private bool HoSoGiaSuExists(int id)
        {
          return (_context.HoSoGiaSu?.Any(e => e.ID_GiaSu == id)).GetValueOrDefault();
        }
    }
}
