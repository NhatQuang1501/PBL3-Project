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

namespace PBL3_Project.Pages.Admin.QLACPH
{
    public class EditModel : PageModel
    {
        private readonly PBL3_Project.Data.PBL3_ProjectContext _context;

        public EditModel(PBL3_Project.Data.PBL3_ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AccountPhuHuynh AccountPhuHuynh { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.AccountPhuHuynh == null)
            {
                return NotFound();
            }

            var accountphuhuynh =  await _context.AccountPhuHuynh.FirstOrDefaultAsync(m => m.ID_PhuHuynh == id);
            if (accountphuhuynh == null)
            {
                return NotFound();
            }
            AccountPhuHuynh = accountphuhuynh;
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

            _context.Attach(AccountPhuHuynh).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccountPhuHuynhExists(AccountPhuHuynh.ID_PhuHuynh))
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

        private bool AccountPhuHuynhExists(int id)
        {
          return (_context.AccountPhuHuynh?.Any(e => e.ID_PhuHuynh == id)).GetValueOrDefault();
        }
    }
}
