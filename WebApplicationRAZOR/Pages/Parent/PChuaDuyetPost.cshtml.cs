using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace PBL3_Project.Pages.Parent
{
    public class PChuaDuyetPostModel : PageModel
    {
      // [Authorize(Roles = "Parent")]
        public void OnGet()
        {
        }
    }
}
