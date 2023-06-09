using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.Models;

namespace WebApplicationRAZOR.Pages.Tutor
{
    //[Authorize(Roles = $"{RolesApp.Tutor}")]
    public class THomeModel : PageModel
    {
        private readonly PBL3_ProjectContext _context;
        public List<BaiDang> Posts { get; set; }
        public THomeModel(PBL3_ProjectContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            //Posts = _context.BaiDang.ToList();
            Posts = _context.BaiDang.Where(p => p.TinhTrangDuyet == true && p.TinhTrang == false).ToList();
        }
    }
}
