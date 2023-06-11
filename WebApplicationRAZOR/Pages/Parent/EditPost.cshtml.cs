using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.Models;
using PBL3_Project.ViewModel;
using System.Data;

namespace PBL3_Project.Pages.Parent
{
    [Authorize(Roles = $"{RolesApp.Parent}")]
    public class EditPostModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;

        //public void OnGet()
        //{
        //}

        private readonly PBL3_ProjectContext dBContext;

        [BindProperty]
        public BaiDang BaiDang { get; set; }

        public EditPostModel(PBL3_ProjectContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public async Task OnGet(int id)
        {
            BaiDang = await dBContext.BaiDang.FindAsync(id);
        }
        
        public async Task<IActionResult> OnPostSave()
        {
            var existingPost = await dBContext.BaiDang.FindAsync(BaiDang.ID_BaiDang);
            if (existingPost != null)
            {
                existingPost.ID_PhuHuynh = BaiDang.ID_PhuHuynh;
                existingPost.TrinhDoHocVan = BaiDang.TrinhDoHocVan;
                existingPost.MonHoc = BaiDang.MonHoc;
                existingPost.HocPhi = BaiDang.HocPhi;
                existingPost.Lop = BaiDang.Lop;
                existingPost.SoBuoi = BaiDang.SoBuoi;
                existingPost.SoHocVien = BaiDang.SoHocVien;
                existingPost.TinhTrang = BaiDang.TinhTrang;
                existingPost.ThoiGian = BaiDang.ThoiGian;
                existingPost.DiaChi = BaiDang.DiaChi;
                existingPost.GhiChu = BaiDang.GhiChu;
                existingPost.TinhTrangDuyet = false;
            }
            await dBContext.SaveChangesAsync();
            return RedirectToPage("/parent/pchuaduyetpost");
        }

        public async Task<IActionResult> OnPostDelete()
        {
            var existingPost = await dBContext.BaiDang.FindAsync(BaiDang.ID_BaiDang);
            if (existingPost != null)
            {
                dBContext.BaiDang.Remove(existingPost);
                await dBContext.SaveChangesAsync();
            }
            return RedirectToPage("/parent/pchuaduyetpost");
        }

        public async Task<IActionResult> OnGetLogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToPage("/Index");
        }
    }
}
