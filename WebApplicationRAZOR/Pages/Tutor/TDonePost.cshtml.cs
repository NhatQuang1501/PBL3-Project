using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.Models;
using PBL3_Project.ViewModel;
using System.Data;

namespace PBL3_Project.Pages.Tutor
{
    [Authorize(Roles = $"{RolesApp.Tutor}")]
    public class TDonePostModel : PageModel
    {
        //public void OnGet()
        //{
        //}
        private readonly PBL3_ProjectContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;
        public List<SuatDayDaNhan> SuatDayDaNhans { get; set; }
        public BaiDang BaiDang { get; set; }
        public List<BaiDang> Posts { get; set; }

       // public SuatDayDaNhan SuatDayDaNhan { get; set; }

        public TDonePostModel(PBL3_ProjectContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            //Posts = _context.BaiDang.ToList();
            //SuatDayDaNhans = _context.SuatDayDaNhan.Where(p => p.ID_GiaSu == 5).ToList();
            //foreach (var SuatDayDaNhan in SuatDayDaNhans)
            //{
            //    Posts = _context.BaiDang.Where(p => p.ID_BaiDang == SuatDayDaNhan.ID_BaiDang).ToList();
            //}
            var idBaiDangList = _context.SuatDayDaNhan.Where(sddk => sddk.ID_GiaSu == "5").Select(sddk => sddk.ID_BaiDang).ToList();
            Posts = _context.BaiDang.Where(bd => idBaiDangList.Contains(bd.ID_BaiDang)).ToList();
        }

        public async Task<IActionResult> OnGetLogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToPage("/Index");
        }

    }
}
