using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.Models;
using PBL3_Project.ViewModel;

namespace PBL3_Project.Pages.Admin
{
    [Authorize(Roles = $"{RolesApp.Admin}")]
    public class QLTInfoModel : PageModel
    {
        private readonly PBL3_ProjectContext dBContext;

        [BindProperty]
        public HoSoGiaSu HoSoGiaSu { get; set; }

        public QLTInfoModel(PBL3_ProjectContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public void OnGet(int id)
        {
            HoSoGiaSu = dBContext.HoSoGiaSu.Find(id);
        }
      
        public IActionResult OnPostDelete()
        {
            var existingHoso = dBContext.HoSoGiaSu.Find(HoSoGiaSu.ID_GiaSu);
            if (existingHoso != null)
            {
                dBContext.HoSoGiaSu.Remove(existingHoso);
                dBContext.SaveChanges();
            }
            return RedirectToPage("/admin/qlthoso");
        }
    }
}

       