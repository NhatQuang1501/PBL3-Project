using System.ComponentModel.DataAnnotations;

namespace PBL3_Project.Models
{
    public class SuatDayDangKi
    {
        [Key]
        public int ID_SuatDayDangKi { get; set; }
        public int ID_BaiDang { get; set; }
        public int ID_GiaSu { get; set; }
    }
}
