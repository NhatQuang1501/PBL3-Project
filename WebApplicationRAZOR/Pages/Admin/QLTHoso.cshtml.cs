using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.Models;

namespace PBL3_Project.Pages.Admin
{
    //[Authorize(Roles = $"{RolesApp.Admin}")]
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
        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var exitingPost = await dbContext.HoSoGiaSu.FindAsync(id);
            if (exitingPost != null)
            {
                dbContext.HoSoGiaSu.Remove(exitingPost);
                dbContext.SaveChanges();
            }
            HoSoGiaSus =  dbContext.HoSoGiaSu.ToList();
            return Page();
        }
    }
}
