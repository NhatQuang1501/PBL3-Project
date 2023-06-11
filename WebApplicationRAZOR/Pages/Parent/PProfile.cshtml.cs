using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.ViewModel;
using System.Data;

namespace PBL3_Project.Pages.Parent
{
    [Authorize(Roles = $"{RolesApp.Parent}")]
    public class PProfileModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnGetLogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToPage("/Index");
        }
    }
}
