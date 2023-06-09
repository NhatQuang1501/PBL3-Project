using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Win32;
using PBL3_Project.Data;
using PBL3_Project.Models;
using PBL3_Project.ViewModel;
using System.Data;

namespace WebApplicationRAZOR.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly PBL3_ProjectContext _context;

        [BindProperty]
        public Register Model { get; set; }
        [BindProperty]
        public bool IsParent { get; set; }
        public RegisterModel(
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
        public async Task OnGet()
        {
            if(!await _roleManager.RoleExistsAsync(RolesApp.Admin))
            {
                await _roleManager.CreateAsync(new IdentityRole(RolesApp.Admin));
                await _roleManager.CreateAsync(new IdentityRole(RolesApp.Parent));
                await _roleManager.CreateAsync(new IdentityRole(RolesApp.Tutor));
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
                    string role = RolesApp.Parent;
                    if (IsParent == false)
                    {
                        role = RolesApp.Tutor;
                    }
                    if (!string.IsNullOrEmpty(role))
                    {
                        await _userManager.AddToRoleAsync(user, role);
                        if(role == "Parent")
                        {
                            var par = new HoSoPhuHuynh()
                            {
                                Email = Model.Email,
                                PasswordAcc = Model.Password,
                                //ID_PhuHuynh = user.Id
                            };
                            _context.HoSoPhuHuynh.Add(par);
                        }
                        else
                        {
                            var tut = new HoSoGiaSu()
                            {
                                Email = Model.Email,
                                PasswordAcc = Model.Password,
                                //ID_GiaSu = user.Id
                            };
                            _context.HoSoGiaSu.Add(tut);
                        }
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
