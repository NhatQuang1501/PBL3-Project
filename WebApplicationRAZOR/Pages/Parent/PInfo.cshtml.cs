using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.Models;
using PBL3_Project.ViewModel;

namespace PBL3_Project.Pages.Parent
{
    [Authorize(Roles = $"{RolesApp.Parent}")]
    public class PInfoModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly PBL3_ProjectContext _context;
        [BindProperty]
        public HoSoPhuHuynh AddPInfor { get; set; }

        public PInfoModel(PBL3_ProjectContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            var infor = new Models.HoSoPhuHuynh()
            {
               
                TenAcc = "2",
                PasswordAcc = "2",
                TenPhuHuynh = AddPInfor.TenPhuHuynh,
                DiaChi = AddPInfor.DiaChi,
                SoDienThoai = AddPInfor.SoDienThoai,
                Email = "2@gmail.com",
                GioiTinh = AddPInfor.GioiTinh,
                NgaySinh = AddPInfor.NgaySinh,

            };
            _context.HoSoPhuHuynh.Add(infor);
            _context.SaveChanges();
            return RedirectToPage("/Parent/PHome");
        }

        public async Task<IActionResult> OnGetLogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToPage("/Index");
        }
    }
}
