using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PBL3_Project.Data;
using PBL3_Project.Models;

namespace PBL3_Project.Pages.Admin.QLHSGS
{
    public class DeleteModel : PageModel
    {
        private readonly PBL3_Project.Data.PBL3_ProjectContext _context;

        public DeleteModel(PBL3_Project.Data.PBL3_ProjectContext context)
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

            var hosogiasu = await _context.HoSoGiaSu.FirstOrDefaultAsync(m => m.ID_GiaSu == id);

            if (hosogiasu == null)
            {
                return NotFound();
            }
            else 
            {
                HoSoGiaSu = hosogiasu;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.HoSoGiaSu == null)
            {
                return NotFound();
            }
            var hosogiasu = await _context.HoSoGiaSu.FindAsync(id);

            if (hosogiasu != null)
            {
                HoSoGiaSu = hosogiasu;
                _context.HoSoGiaSu.Remove(HoSoGiaSu);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
