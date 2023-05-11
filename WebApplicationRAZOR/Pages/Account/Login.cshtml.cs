using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.Net;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace PBL3_Project.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credential Credential { get; set; }
        public void OnGet()
        {
            this.Credential = new Credential { UserName = "admin" };
        }
        public void OnPost()
        {
        }
    }

    public class Credential
    {
        [RequiredAttribute]
        [Display(Name="Tên đăng nhập")]
        public string UserName { get; set; }
        [RequiredAttribute]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }
    }
}
