using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.Models;

namespace PBL3_Project.Pages.Parent
{
    //[Authorize(Roles = "Parent")]
    public class PDuyetPostModel : PageModel
    {
        private readonly PBL3_ProjectContext _context;
        public List<BaiDang> Posts { get; set; }
        public PDuyetPostModel(PBL3_ProjectContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Posts = _context.BaiDang.Where(p => p.TinhTrangDuyet == true && p.TinhTrang == false).ToList();
        }
        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var exitingPost = _context.BaiDang.Find(id);
            if (exitingPost != null)
            {
                _context.BaiDang.Remove(exitingPost);
                _context.SaveChanges();
            }
            Posts = _context.BaiDang.Where(p => p.TinhTrangDuyet == false && p.TinhTrang == false).ToList();
            return Page();
        }
    }
}
