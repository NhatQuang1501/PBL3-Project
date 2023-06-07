using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_Project.Models
{
    public class SuatDayDaNhan
    {
        [Key]
        public int? ID_SuatDayDaNhan { get; set; }

        [ForeignKey("ID_BaiDang")]
        public int ID_BaiDang { get; set; }

        [ForeignKey("ID_GiaSu")]
        public int ID_GiaSu { get; set; }
    }
}