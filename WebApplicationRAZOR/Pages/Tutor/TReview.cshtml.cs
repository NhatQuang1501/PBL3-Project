using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using PBL3_Project.Data;
using PBL3_Project.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Identity;
using PBL3_Project.ViewModel;

namespace PBL3_Project.Pages.Tutor
{
    [Authorize(Roles = $"{RolesApp.Tutor}")]
    public class TReviewModel : PageModel
    {
        private readonly PBL3_ProjectContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;
        [BindProperty]
        public List<PhanHoi> PhanHois { get; set; }
        public HoSoGiaSu tutor { get; set; }
        public TReviewModel(PBL3_ProjectContext context)
        {
            _context = context;
        }
        //public TReviewModel(PBL3_ProjectContext context)
        //{
        //    _context = context ?? throw new ArgumentNullException(nameof(context));
        //}
        public void OnGet()
        {
            PhanHois = _context.PhanHoi.ToList();
            //PhanHois = result.ToList();
            

        }

        public async Task<IActionResult> OnGetLogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToPage("/Index");
        }
    }
}




