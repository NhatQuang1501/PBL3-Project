using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_Project.Models
{
    public class PhanHoi
    {
        [Key]
        public int ID_PhanHoi { get; set; }

        [ForeignKey("ID_GiaSu")]
        public string ID_GiaSu { get; set; }

        [ForeignKey("ID_Phuhuynh")]
        public string ID_PhuHuynh { get; set; }
        public string? NoiDungPhanHoi { get; set; }
        public double DiemDanhGia { get; set; }
        //public virtual HoSoGiaSu IdGiaSuNavigation { get; set; } = null!;
        //public virtual HoSoPhuHuynh IdPhuHuynhNavigation { get; set; } = null!;
    }
}