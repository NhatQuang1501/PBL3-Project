using System.ComponentModel.DataAnnotations;

namespace PBL3_Project.Models.Domain
{
    public class PhanHoi
    {
        [Key]
        public int ID_PhanHoi { get; set; }
        public int ID_GiaSu { get; set; }
        public int ID_PhuHuynh { get; set; }
        public string NoiDungPhanHoi { get; set; }
        public double DiemDanhGia { get; set; }
    }
}
