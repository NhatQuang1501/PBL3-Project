using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.Models;
using PBL3_Project.Pages.Parent;
using PBL3_Project.ViewModel;

namespace PBL3_Project.Pages.Tutor
{
    [Authorize(Roles = $"{RolesApp.Tutor}")]
    public class TPersonalModel : PageModel
    {

        private readonly PBL3_ProjectContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        [BindProperty]
        public HoSoGiaSu AddTInfor { get; set; }
        public int TutorId { get; set; }

        public TPersonalModel(PBL3_ProjectContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public void OnGet()
        {
            var user = _userManager.GetUserAsync(User);
            if(user != null)
            {
                TutorId = user.Id;
            }
            AddTInfor =  _context.HoSoGiaSu.Find(TutorId);
        }
        public IActionResult OnPost()
        {
            var infor = new Models.HoSoGiaSu()
            {
                TenAcc = "Tutor1",
                PasswordAcc ="Tutor1@",
                TenGiaSu=AddTInfor.TenGiaSu,
                DiaChi = AddTInfor.DiaChi,
                TrinhDoHocVan=AddTInfor.TrinhDoHocVan,
                SoDienThoai = AddTInfor.SoDienThoai,
                Email = "Tutor1@gmail.com",
                GioiTinh = AddTInfor.GioiTinh,
                NgaySinh = AddTInfor.NgaySinh,
                MonHoc = AddTInfor.MonHoc,
                HocPhi = AddTInfor.HocPhi
            };
             _context.HoSoGiaSu.Add(infor);
            _context.SaveChanges();
            return RedirectToPage("/Tutor/THome");
        }

        public async Task<IActionResult> OnGetLogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToPage("/Index");
        }
    }
}
