using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace PBL3_Project.Pages.Parent
{
    //[Authorize(Roles = $"{RolesApp.Parent}")]
    public class PProfileModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
