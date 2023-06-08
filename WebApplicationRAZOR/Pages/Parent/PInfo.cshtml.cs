using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.Models;

namespace PBL3_Project.Pages.Parent
{
    //[Authorize(Roles = "Parent")]
    public class PInfoModel : PageModel
    {
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

    }
}

