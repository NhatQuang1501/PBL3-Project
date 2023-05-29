using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PBL3_Project.Data;
using PBL3_Project.Models.Domain;

namespace PBL3_Project.Pages.Admin.QLACGS
{
    public class EditModel : PageModel
    {
        private readonly PBL3_Project.Data.PBL3_ProjectContext _context;

        public EditModel(PBL3_Project.Data.PBL3_ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AccountGiaSu AccountGiaSu { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.AccountGiaSu == null)
            {
                return NotFound();
            }

            var accountgiasu =  await _context.AccountGiaSu.FirstOrDefaultAsync(m => m.ID_GiaSu == id);
            if (accountgiasu == null)
            {
                return NotFound();
            }
            AccountGiaSu = accountgiasu;
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

            _context.Attach(AccountGiaSu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccountGiaSuExists(AccountGiaSu.ID_GiaSu))
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

        private bool AccountGiaSuExists(int id)
        {
          return (_context.AccountGiaSu?.Any(e => e.ID_GiaSu == id)).GetValueOrDefault();
        }
    }
}
