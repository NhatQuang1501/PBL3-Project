using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.Models;
using PBL3_Project.Models.ViewModels;

namespace PBL3_Project.Pages.Parent
{
    public class CreatePostModel : PageModel
    {
        private readonly PBL3_ProjectContext _context;
        [BindProperty]
        public AddPost AddPostRequest { get; set; }
        public void OnGet()
        {
        }

        public IActionResult Post()
        {
            var post = new Models.Domain.BaiDang()
            {
                ID_PhuHuynh = 1,
                TrinhDoHocVan = AddPostRequest.TrinhDoHocVan,
                MonHoc = AddPostRequest.MonHoc,
                HocPhi = AddPostRequest.HocPhi,
                Lop = AddPostRequest.Lop,
                SoBuoi = AddPostRequest.SoBuoi,
                SoHocVien = AddPostRequest.SoHocVien,
                TinhTrang = AddPostRequest.TinhTrang,
                ThoiGian = AddPostRequest.ThoiGian,
                DiaChi = AddPostRequest.DiaChi,
                GhiChu = AddPostRequest.GhiChu,
            };
            _context.BaiDang.Add(post);
            _context.SaveChanges();

            return RedirectToPage("/Parent/PHome");
        }
        
        public IActionResult OnPostPost() 
        {
            var post = new Models.Domain.BaiDang()
            {
                ID_PhuHuynh = 1,
				TrinhDoHocVan = AddPostRequest.TrinhDoHocVan,
		        MonHoc = AddPostRequest.MonHoc,
		        HocPhi = AddPostRequest.HocPhi,
	            Lop = AddPostRequest.Lop,
		        SoBuoi = AddPostRequest.SoBuoi,
		        SoHocVien = AddPostRequest.SoHocVien,
		        TinhTrang = AddPostRequest.TinhTrang,
		        ThoiGian = AddPostRequest.ThoiGian,
		        DiaChi = AddPostRequest.DiaChi,
		        GhiChu = AddPostRequest.GhiChu,
	        };
            _context.BaiDang.Add(post);
            _context.SaveChanges();

            return RedirectToPage("/Parent/PHome");
        }
    }
}
