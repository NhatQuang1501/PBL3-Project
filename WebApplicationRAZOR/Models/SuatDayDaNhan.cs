using System.ComponentModel.DataAnnotations;

namespace PBL3_Project.Models
{
    public class SuatDayDaNhan
    {
        [Key]
        public int ID_SuatDayDaNhan { get; set; }
        public int ID_BaiDang { get; set; }
        public int ID_GiaSu { get; set; }
    }
}
