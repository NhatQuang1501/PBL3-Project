using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.Models;
using PBL3_Project.ViewModel;
using System.Security.Permissions;
using System.Web;

namespace WebApplicationRAZOR.Pages.Parent
{

    public class PHomeModel : PageModel
    {
        private readonly PBL3_ProjectContext _context;
        public List<BaiDang> Posts { get; set; }
        [BindProperty]
        public Filter Model { get; set; }
       
        public PHomeModel(PBL3_ProjectContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Posts = _context.BaiDang.Where(p => p.TinhTrangDuyet == true && p.TinhTrang == false).ToList();
        }

        public IActionResult OnPostByFilter()
        {
            var query = _context.BaiDang.Where(p => p.TinhTrangDuyet == true && p.TinhTrang == false).AsQueryable();
            

            string monhoc = Request.Form["MonHoc"];
            monhoc = monhoc.Replace(" ", "").ToLower();

            string lop = Request.Form["Lop"];

            string khuvuc = Request.Form["KhuVuc"];
            khuvuc = khuvuc.Replace(" ", "").ToLower();

            string sohv = Request.Form["SoHocVien"];

            string sobuoi = Request.Form["SoBuoi"];

            string hocphimax = Request.Form["HocPhiMax"];
            string hocphimin = Request.Form["HocPhiMin"];

            if (!string.IsNullOrEmpty(monhoc))
            {
                query = query.Where(p => p.MonHoc.Replace(" ", "").ToLower() == monhoc.Replace(" ", "").ToLower());
            }

            if (!string.IsNullOrEmpty(lop))
            {
                query = query.Where(p => p.Lop.Replace(" ", "").ToLower() == lop.Replace(" ", "").ToLower());
            }

            if (!string.IsNullOrEmpty(khuvuc))
            {
                query = query.Where(p => p.DiaChi.Replace(" ", "").ToLower().Contains(khuvuc.Replace(" ", "").ToLower()));
            }

            if (!string.IsNullOrEmpty(sohv))
            {
                query = query.Where(p => p.SoHocVien.ToString() == sohv);
            }

            if (!string.IsNullOrEmpty(sobuoi))
            {
                query = query.Where(p => p.SoBuoi.ToString() == sobuoi);
            }

            if (!string.IsNullOrEmpty(hocphimax))
            {
                query = query.Where(p => Compare(p.HocPhi.ToString(), hocphimax.ToString()) <= 0);
            }

            if (!string.IsNullOrEmpty(hocphimin))
            {
                query = query.Where(p => Compare(p.HocPhi.ToString(), hocphimin.ToString()) >= 0);
            }



            Posts = query.ToList();
            return Page();
        }

        private int Compare(string v1, string v2)
        {
            return string.Compare(v1, v2);
        }
    }
}
