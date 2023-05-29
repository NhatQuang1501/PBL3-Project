using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PBL3_Project.Data;
using PBL3_Project.Models.Domain;

namespace PBL3_Project.Pages.Admin.QLACPH
{
    public class DetailsModel : PageModel
    {
        private readonly PBL3_Project.Data.PBL3_ProjectContext _context;

        public DetailsModel(PBL3_Project.Data.PBL3_ProjectContext context)
        {
            _context = context;
        }

      public AccountPhuHuynh AccountPhuHuynh { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.AccountPhuHuynh == null)
            {
                return NotFound();
            }

            var accountphuhuynh = await _context.AccountPhuHuynh.FirstOrDefaultAsync(m => m.ID_PhuHuynh == id);
            if (accountphuhuynh == null)
            {
                return NotFound();
            }
            else 
            {
                AccountPhuHuynh = accountphuhuynh;
            }
            return Page();
        }
    }
}
