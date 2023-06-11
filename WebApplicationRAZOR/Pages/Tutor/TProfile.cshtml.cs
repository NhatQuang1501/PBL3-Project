using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.ViewModel;
using System.Data;

namespace WebApplicationRAZOR.Pages.Tutor
{
    [Authorize(Roles = $"{RolesApp.Tutor}")]
    public class TProfileModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly PBL3_ProjectContext _context;

        [BindProperty]
        public ChangePassword Model { get; set; }
        [BindProperty]
        public string Email { get; set; }
        public TProfileModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            PBL3_ProjectContext context)

        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._roleManager = roleManager;
            this._context = context;
        }
        public async void OnGet()
        {
            var user = await _userManager.GetUserAsync(User);
            Email = user.Email;
        }

        public async Task<IActionResult> OnGetLogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToPage("/Index");
        }
    }
}
