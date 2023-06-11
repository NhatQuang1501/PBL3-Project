using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.ViewModel;

namespace PBL3_Project.Pages.Parent
{
    //[Authorize(Roles = $"{RolesApp.Parent}")]
    public class PChangePassModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly PBL3_ProjectContext _context;

        [BindProperty]
        public ChangePassword Model { get; set; }
        [BindProperty]
        public string Email { get; set; }
        public PChangePassModel(
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
        //public async Task<IActionResult> OnPostChangePasswordAsync()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = await _userManager.GetUserAsync(User);
        //        if (user == null)
        //        {
        //            return NotFound();
        //        }
        //        if (Model.NewPassword != Model.ConfirmPassword)
        //        {
        //            ModelState.AddModelError("", "Password and confirmation password did not match");
        //            return Page();
        //        }
        //        var changePasswordResult = await _userManager.ChangePasswordAsync(user, Model.CurrentPassword, Model.NewPassword);
        //        if (changePasswordResult.Succeeded)
        //        {
        //            await _signInManager.SignOutAsync();
        //            return RedirectToPage("/Account/Login");
        //        }

        //        foreach (var error in changePasswordResult.Errors)
        //        {
        //            ModelState.AddModelError("", error.Description);
        //        }
        //    }
        //    return Page();
        //}

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound();
            }
            if (Model.NewPassword != Model.ConfirmPassword)
            {
                ModelState.AddModelError("", "Password and confirmation password did not match");
                return Page();
            }
            var changePWResult = await _userManager.ChangePasswordAsync(user, Model.CurrentPassword, Model.NewPassword);
            if (!changePWResult.Succeeded)
            {
                foreach (var error in changePWResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return Page();
            }

            await _signInManager.RefreshSignInAsync(user);
            return RedirectToPage("/Index");
        }


    }
}

