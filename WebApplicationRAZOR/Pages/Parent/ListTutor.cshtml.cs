using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.Models;

namespace PBL3_Project.Pages.Parent
{
    public class ListTutorModel : PageModel
    {
        private readonly PBL3_ProjectContext _context;

        [BindProperty]
        public List<HoSoGiaSu> ListGiaSu { get; set; }
        public static int idBaiDang { get; set; }

        public ListTutorModel(PBL3_ProjectContext context)
        {
            this._context = context;
        }
        public async Task OnGet(int id)
        {
            var idGiaSuList = _context.SuatDayDangKi.Where(sddk => sddk.ID_BaiDang == id).Select(sddk => sddk.ID_GiaSu).ToList();
            ListGiaSu = _context.HoSoGiaSu.Where(gs => idGiaSuList.Contains(gs.ID_GiaSu)).ToList();
            idBaiDang = id;
        }
        public IActionResult OnPostChoose(int id)
        {
            //HoSoGiaSu giaSu = _context.HoSoGiaSu.Where(hs => hs.ID_GiaSu == id).ToList().FirstOrDefault();
            SuatDayDaNhan sddn = new Models.SuatDayDaNhan() 
            { 
                ID_BaiDang = idBaiDang,
                ID_GiaSu = id
            };
            _context.SuatDayDaNhan.Add(sddn);
            _context.SaveChanges();

            BaiDang bd = _context.BaiDang.Find(idBaiDang);
            if (bd != null)
            {
                bd.TinhTrang = true;
                bd.ID_GiaSu = id;
            }
            _context.SaveChanges();

            return RedirectToPage("/Parent/PDuyetPost");
        }
    }
}
