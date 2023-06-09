using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.Models;

namespace PBL3_Project.Pages.Parent
{
    public class PChuaDuyetPostModel : PageModel
    {
        private readonly PBL3_ProjectContext _context;
        public List<BaiDang> Posts { get; set; }
        public BaiDang BaiDang { get; set; }
        public PChuaDuyetPostModel(PBL3_ProjectContext context)
        {
            _context = context;
        }
        public async Task OnGet()
        {
            Posts = _context.BaiDang.Where(p => p.TinhTrangDuyet == false && p.TinhTrang == false).ToList();
        }
        public async Task<IActionResult> OnPostDeleteAsync()
        {
            var existingPost = await _context.BaiDang.FindAsync(BaiDang.ID_BaiDang);
            if (existingPost != null)
            {
                _context.BaiDang.Remove(existingPost);
               await _context.SaveChangesAsync();
            }
            return RedirectToPage("/parent/pchuaduyetpost");
        }
    }
}
