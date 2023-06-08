using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.Models;

namespace PBL3_Project.Pages.Admin
{
    public class QLTHosoModel : PageModel
    {
        private readonly PBL3_ProjectContext dbContext;
        public List<HoSoGiaSu> HoSoGiaSus { get; set; }
        public QLTHosoModel(PBL3_ProjectContext dbContext)
        {
            this.dbContext = dbContext;

        }
        public void OnGet()
        {
            HoSoGiaSus = dbContext.HoSoGiaSu.ToList();
        }
        
    }
}
