using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.Models;
using PBL3_Project.Pages.Parent;

namespace PBL3_Project.Pages.Tutor
{
    //[Authorize(Roles = $"{RolesApp.Tutor}")]
    public class TPersonalModel : PageModel
    {

        private readonly PBL3_ProjectContext _context;
        [BindProperty]
        public HoSoGiaSu AddTInfor { get; set; }

        public TPersonalModel(PBL3_ProjectContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
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
    }
}
