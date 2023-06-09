using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using PBL3_Project.Data;
using PBL3_Project.Models;

namespace PBL3_Project.Pages.Tutor
{
    //[Authorize(Roles = $"{RolesApp.Tutor}")]
    public class TReviewModel : PageModel
    {
        private readonly PBL3_ProjectContext _context;
        [BindProperty]
        public List<PhanHoi> PhanHois { get; set; }
        public void OnGet()
        {
            PhanHois = _context.PhanHoi.ToList();
        }
        public TReviewModel(PBL3_ProjectContext context)
        {
            _context = context;
        }
    }
}



