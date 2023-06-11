using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.Models;
using System.Data;

namespace PBL3_Project.Pages.Tutor
{
    ///[Authorize(Roles = $"{RolesApp.Tutor}")]
    public class TDangKiPostModel : PageModel
    {
        //public void OnGet()
        //{
        //}
        private readonly PBL3_ProjectContext _context;
        public List<SuatDayDangKi> SuatDayDangKis { get; set; }
        public BaiDang BaiDang { get; set; }
        public List<BaiDang> Posts { get; set; }

        public SuatDayDangKi SuatDayDangKi { get; set; }

        public TDangKiPostModel(PBL3_ProjectContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            //Posts = _context.BaiDang.ToList();
            //SuatDayDangKis = _context.SuatDayDangKi.Where(p => p.ID_GiaSu == 5).ToList();
            //foreach(var SuatDayDangKi in SuatDayDangKis)
            //{
            //    Posts= _context.BaiDang.Where(p=>p.ID_BaiDang == SuatDayDangKi.ID_BaiDang).ToList();
            //}
            // public List<BaiDang> TimBaiDangTheoGiaSu(string idGiaSu) { var baiDangList = _context.BaiDang.Where(bd => bd.SuatDayDangKies.Any(sddk => sddk.ID_GiaSu == idGiaSu)).ToList(); return baiDangList; }
            //Posts = _context.BaiDang.Where(p => p.SuatDayDangKi == SuatDayDangKi.ID_BaiDang).ToList();
            //var idBaiDangList = _context.SuatDayDangKy.Where(sddk => sddk.ID_GiaSu == idGiaSu).Select(sddk => sddk.ID_BaiDang).ToList(); 
            //var baiDangList = _context.BaiDang.Where(bd => idBaiDangList.Contains(bd.ID_BaiDang)).ToList(); return baiDangList;
            var idBaiDangList = _context.SuatDayDangKi.Where(sddk => sddk.ID_GiaSu == 5).Select(sddk => sddk.ID_BaiDang).ToList();
            Posts = _context.BaiDang.Where(bd => idBaiDangList.Contains(bd.ID_BaiDang)).ToList(); 
           
        }
       
    }
}
