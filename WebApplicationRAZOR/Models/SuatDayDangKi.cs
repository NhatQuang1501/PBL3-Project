using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_Project.Models
{
    public class SuatDayDangKi
    {
        [Key]
        public int? ID_SuatDayDangKi { get; set; }

        [ForeignKey("ID_BaiDang")]
        public int ID_BaiDang { get; set; }

        [ForeignKey("ID_GiaSu")]
        public int ID_GiaSu { get; set; }
    }
}