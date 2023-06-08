using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Win32;
using PBL3_Project.ViewModel;
using System.Data;

namespace WebApplicationRAZOR.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        [BindProperty]
        public Register Model { get; set; }
        [BindProperty]
        public bool IsParent { get; set; }
        public RegisterModel(
            UserManager<IdentityUser> userManager, 
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this.roleManager = roleManager;
        }
        public async Task OnGet()
        {
            if(!await roleManager.RoleExistsAsync(RolesApp.Admin))
            {
                await roleManager.CreateAsync(new IdentityRole(RolesApp.Admin));
            }
            if (!await roleManager.RoleExistsAsync(RolesApp.Parent))
            {
                await roleManager.CreateAsync(new IdentityRole(RolesApp.Parent));
            }
            if (!await roleManager.RoleExistsAsync(RolesApp.Tutor))
            {
                await roleManager.CreateAsync(new IdentityRole(RolesApp.Tutor));
            }
        }
        public async Task<IActionResult> OnPostCreateAccAsync()
        {
            IsParent = true;
            if (ModelState.IsValid)
            {
                var user = new IdentityUser()
                {
                    UserName = Model.Email,
                    Email = Model.Email
                };
                if(Model.Password != Model.ConfirmPassword)
        {
                    ModelState.AddModelError("", "Password and confirmation password did not match");
                    return Page();
                }
                var result = await _userManager.CreateAsync(user, Model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    string role = "Parent";
                    if (IsParent == false)
                    {
                        role = "Tutor";
                    }
                    if (!string.IsNullOrEmpty(role))
                    {
                        await _userManager.AddToRoleAsync(user, role);
                    }
                    return RedirectToPage("/Account/Login");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return Page();
        }
    }
}
