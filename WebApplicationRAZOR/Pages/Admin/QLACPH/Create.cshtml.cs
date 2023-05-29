using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PBL3_Project.Data;
using PBL3_Project.Models.Domain;

namespace PBL3_Project.Pages.Admin.QLACPH
{
    public class CreateModel : PageModel
    {
        private readonly PBL3_Project.Data.PBL3_ProjectContext _context;

        public CreateModel(PBL3_Project.Data.PBL3_ProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AccountPhuHuynh AccountPhuHuynh { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.AccountPhuHuynh == null || AccountPhuHuynh == null)
            {
                return Page();
            }

            _context.AccountPhuHuynh.Add(AccountPhuHuynh);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
