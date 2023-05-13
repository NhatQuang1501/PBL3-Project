using System.ComponentModel.DataAnnotations;

namespace PBL3_Project.Models
{
    public class AccountPhuHuynh
    {
        [Key]
        public int ID_PhuHuynh { get; set; }
        public string TenAcc { get; set; }
        public string PasswordAcc { get; set; }
    }
}
