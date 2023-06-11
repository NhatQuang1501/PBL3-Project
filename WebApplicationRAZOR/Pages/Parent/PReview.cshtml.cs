using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using PBL3_Project.Data;
using PBL3_Project.Models;
using PBL3_Project.ViewModel;
using Microsoft.AspNetCore.Identity;

namespace PBL3_Project.Pages.Parent
{
    [Authorize(Roles = $"{RolesApp.Parent}")]
    public class PReviewModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly PBL3_ProjectContext _context;
        [BindProperty]
        public PhanHoi AddPhanHoiRequest { get; set; }
        public BaiDang BaiDang { get; set; }
        public SuatDayDaNhan SuatDayDaNhan { get; set; }

        public void OnGet(int id)
        {
            BaiDang = _context.BaiDang.Find(id);
            SuatDayDaNhan = _context.SuatDayDaNhan.Find(id);
        }
        public PReviewModel(PBL3_ProjectContext context)
        {
            _context = context;
        }
        

       
       
        //public IActionResult OnPostEdit()
        //{
        //    var existingHoso = dBContext.HoSoPhuHuynh.Find(HoSoPhuHuynh.ID_PhuHuynh);
        //    if (existingHoso != null)
        //    {
        //        existingHoso.TenPhuHuynh = HoSoPhuHuynh.TenPhuHuynh;
        //        existingHoso.DiaChi = HoSoPhuHuynh.DiaChi;
        //        existingHoso.NgaySinh= HoSoPhuHuynh.NgaySinh;
        //        existingHoso.SoDienThoai= HoSoPhuHuynh.SoDienThoai;
        //    }
        //    dBContext.SaveChanges();
        //    return RedirectToPage("/admin/qlphoso");
        //}

        public IActionResult OnPostPhanHoi()
        {
            var phanhoi = new Models.PhanHoi()
            {
                
                ID_GiaSu = SuatDayDaNhan.ID_GiaSu,
                ID_PhuHuynh = BaiDang.ID_PhuHuynh,
                NoiDungPhanHoi = AddPhanHoiRequest.NoiDungPhanHoi,
                DiemDanhGia = AddPhanHoiRequest.DiemDanhGia,

            };
            _context.PhanHoi.Add(phanhoi);
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



