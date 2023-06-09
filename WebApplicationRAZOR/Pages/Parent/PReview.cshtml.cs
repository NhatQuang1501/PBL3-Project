using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using PBL3_Project.Data;
using PBL3_Project.Models;
using PBL3_Project.ViewModel;

namespace PBL3_Project.Pages.Parent
{
    //[Authorize(Roles = $"{RolesApp.Parent}")]
    public class PReviewModel : PageModel
    {
        private readonly PBL3_ProjectContext _context;
        [BindProperty]
        public PhanHoi AddPhanHoiRequest { get; set; }
        public void OnGet()
        {
        }
        public PReviewModel(PBL3_ProjectContext context)
        {
            _context = context;
        }
        public IActionResult OnPostPhanHoi()
        {
            var phanhoi = new Models.PhanHoi()
            {

                ID_GiaSu = AddPhanHoiRequest.ID_GiaSu,
                ID_PhuHuynh = AddPhanHoiRequest.ID_PhuHuynh,
                NoiDungPhanHoi = AddPhanHoiRequest.NoiDungPhanHoi,
                DiemDanhGia = AddPhanHoiRequest.DiemDanhGia,

            };
            _context.PhanHoi.Add(phanhoi);
            _context.SaveChanges();

            return RedirectToPage("/Parent/PHome");
        }
    }
}



