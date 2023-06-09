using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.Models;
using PBL3_Project.ViewModel;
using System.Data;

namespace PBL3_Project.Pages.Admin
{
    //[Authorize(Roles = $"{RolesApp.Admin}")]
    public class QLPHosoModel : PageModel
    {
        private readonly PBL3_ProjectContext dbContext;
        public List<HoSoPhuHuynh> HoSoPhuHuynhs { get; set; }
        public QLPHosoModel(PBL3_ProjectContext dbContext)
        {
            this.dbContext = dbContext;

        }
        public void OnGet()
        {
            HoSoPhuHuynhs = dbContext.HoSoPhuHuynh.ToList();
        }
       
    }
}
