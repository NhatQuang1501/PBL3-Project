using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.Models;

namespace PBL3_Project.Pages.Parent
{
    //[Authorize(Roles = "Parent")]
    public class CreatePostModel : PageModel
    {
        private readonly PBL3_ProjectContext _context;
        [BindProperty]
        public BaiDang AddPostRequest { get; set; }
        public CreatePostModel(PBL3_ProjectContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }
        /*
         * [Key]
        public int? ID_BaiDang { get; set; }
        [ForeignKey("ID_Phuhuynh")]
        public int ID_PhuHuynh { get; set; }
        public string MonHoc { get; set; }
        public string TrinhDoHocVan { get; set; }
        public int HocPhi { get; set; }
        public string Lop { get; set; }
        public int SoBuoi { get; set; }
        public int SoHocVien { get; set; }
        public bool TinhTrang { get; set; }
        public string ThoiGian { get; set; }
        public string DiaChi { get; set; }
        public string GhiChu { get; set; }
        public bool TinhTrangDuyet { get; set; }
         * */
        public IActionResult OnPost()
        {
            var post = new Models.BaiDang()
            {
                ID_PhuHuynh = 1,
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
    }
}
