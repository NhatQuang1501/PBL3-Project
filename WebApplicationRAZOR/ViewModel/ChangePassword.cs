using System.ComponentModel.DataAnnotations;

namespace PBL3_Project.ViewModel
{
    public class ChangePassword
    {
        [Required]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Required]
        [DataType(nameof(NewPassword), ErrorMessage = "Password and confirmation password did not match")]
        public string ConfirmPassword { get; set; }
    }
}
