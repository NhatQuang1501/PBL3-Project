using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.Models;

namespace PBL3_Project.Pages.Parent
{
    public class PDonePostModel : PageModel
    {
        private readonly PBL3_ProjectContext _context;
        public List<BaiDang> Posts { get; set; }
        public PDonePostModel(PBL3_ProjectContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Posts = _context.BaiDang.Where(p => p.TinhTrangDuyet == true && p.TinhTrang == true).ToList();
        }
    }
}
