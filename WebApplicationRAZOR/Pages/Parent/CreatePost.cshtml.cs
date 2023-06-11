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
    public class CreatePostModel : PageModel
    {
        private readonly PBL3_ProjectContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;
        [BindProperty]
        public BaiDang AddPostRequest { get; set; }
        public CreatePostModel(PBL3_ProjectContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            var post = new Models.BaiDang()
            {
                ID_PhuHuynh = 1,
                ID_GiaSu = 0,
                TrinhDoHocVan = AddPostRequest.TrinhDoHocVan,
                MonHoc = AddPostRequest.MonHoc,
                HocPhi = AddPostRequest.HocPhi,
                Lop = AddPostRequest.Lop,
                SoBuoi = AddPostRequest.SoBuoi,
                SoHocVien = AddPostRequest.SoHocVien,
                TinhTrang = false,
                ThoiGian = AddPostRequest.ThoiGian,
                DiaChi = AddPostRequest.DiaChi,
                GhiChu = AddPostRequest.GhiChu,
                TinhTrangDuyet = false
            };
            _context.BaiDang.Add(post);
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
