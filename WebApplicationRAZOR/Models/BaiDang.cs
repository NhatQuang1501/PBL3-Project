using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_Project.Models
{
    public class BaiDang
    {
        [Key]
        public int? ID_BaiDang { get; set; }
        [ForeignKey("ID_Phuhuynh")]
        public int ID_PhuHuynh { get; set; }
        //public int ID_GiaSu { get; set; }
        public string MonHoc { get; set; }
        public string TrinhDoHocVan { get; set; }
        public int HocPhi { get; set; }
        public string Lop { get; set; }
        public int SoBuoi { get; set; }
        public int SoHocVien { get; set; }
        public bool TinhTrang { get; set; }
        public string ThoiGian { get; set; }
        public string DiaChi { get; set; }
        public string GhiChu { get; set; }
        public bool TinhTrangDuyet { get; set; }
    }
}
