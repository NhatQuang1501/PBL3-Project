using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NuGet.Protocol.Plugins;
using PBL3_Project.ViewModel;

namespace WebApplicationRAZOR.Pages
{
    public class LoginModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        [BindProperty]
        public Login Model { get; set; }
        public LoginModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }
        public void OnGet()
        {
        }
        
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var identityResult = await _signInManager.PasswordSignInAsync(Model.Email, Model.Password, Model.RememberMe, false);
                if (identityResult.Succeeded)
                {
                    var user = await _userManager.FindByEmailAsync(Model.Email);
                    var roles = await _userManager.GetRolesAsync(user);
                    if (roles.Contains(RolesApp.Parent))
                    {
                        return RedirectToPage("/Parent/PHome");
                    }
                    else if(roles.Contains(RolesApp.Tutor))
                    {
                        return RedirectToPage("/Tutor/THome");
                    }
                }
                ModelState.AddModelError("", "Username or Password incorrect");
            }
            return Page();
        }
    }
}