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
    public class PChuaDuyetPostModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly PBL3_ProjectContext _context;
        public List<BaiDang> Posts { get; set; }
        public BaiDang BaiDang { get; set; }
        public PChuaDuyetPostModel(PBL3_ProjectContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            //Posts = _context.BaiDang.ToList();
            Posts = _context.BaiDang.Where(p => p.TinhTrangDuyet == false && p.TinhTrang == false).ToList();
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

        public async Task<IActionResult> OnGetLogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToPage("/Index");
        }
    }
}