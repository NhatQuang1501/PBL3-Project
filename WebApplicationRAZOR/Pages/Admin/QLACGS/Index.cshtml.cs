using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PBL3_Project.Data;
using PBL3_Project.Models.Domain;

namespace PBL3_Project.Pages.Admin.QLACGS
{
    public class IndexModel : PageModel
    {
        private readonly PBL3_Project.Data.PBL3_ProjectContext _context;

        public IndexModel(PBL3_Project.Data.PBL3_ProjectContext context)
        {
            _context = context;
        }

        public IList<AccountGiaSu> AccountGiaSu { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.AccountGiaSu != null)
            {
                AccountGiaSu = await _context.AccountGiaSu.ToListAsync();
            }
        }
    }
}
