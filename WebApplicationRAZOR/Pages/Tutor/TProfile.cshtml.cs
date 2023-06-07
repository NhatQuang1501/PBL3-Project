using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace WebApplicationRAZOR.Pages.Tutor
{
    //[Authorize(Roles = "Tutor")]
    public class TProfileModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
