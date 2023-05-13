using System.ComponentModel.DataAnnotations;

namespace PBL3_Project.Models
{
    public class AccountGiaSu
    {
        [Key]
        public int ID_GiaSu { get; set; }
        public string TenAcc { get; set; }
        public string PasswordAcc { get; set; }
    }
}
