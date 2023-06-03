using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PBL3_Project.Data;
using PBL3_Project.Models;

namespace PBL3_Project.Pages.Admin.QLHSPH
{
    public class DeleteModel : PageModel
    {
        private readonly PBL3_Project.Data.PBL3_ProjectContext _context;

        public DeleteModel(PBL3_Project.Data.PBL3_ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
      public HoSoPhuHuynh HoSoPhuHuynh { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.HoSoPhuHuynh == null)
            {
                return NotFound();
            }

            var hosophuhuynh = await _context.HoSoPhuHuynh.FirstOrDefaultAsync(m => m.ID_PhuHuynh == id);

            if (hosophuhuynh == null)
            {
                return NotFound();
            }
            else 
            {
                HoSoPhuHuynh = hosophuhuynh;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.HoSoPhuHuynh == null)
            {
                return NotFound();
            }
            var hosophuhuynh = await _context.HoSoPhuHuynh.FindAsync(id);

            if (hosophuhuynh != null)
            {
                HoSoPhuHuynh = hosophuhuynh;
                _context.HoSoPhuHuynh.Remove(HoSoPhuHuynh);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
