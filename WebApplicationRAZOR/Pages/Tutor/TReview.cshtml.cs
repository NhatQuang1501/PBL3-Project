using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace PBL3_Project.Pages.Tutor
{
    //[Authorize(Roles = "Tutor")]
    public class TReviewModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
