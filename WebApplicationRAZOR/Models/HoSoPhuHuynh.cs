using System.ComponentModel.DataAnnotations;

namespace PBL3_Project.Models
{
    public class HoSoPhuHuynh
    {
        //public HoSoPhuHuynh()
        //{
        //    BaiDangs = new HashSet<BaiDang>();
        //    PhanHois = new HashSet<PhanHoi>();
        //}
        [Key]
        public int? ID_PhuHuynh { get; set; }
        public string? TenAcc { get; set; }
        public string? PasswordAcc { get; set; }
        public string? TenPhuHuynh { get; set; }
        public string? DiaChi { get; set; }
        public string? SoDienThoai { get; set; }
        public string? Email { get; set; }
        public bool? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        //public virtual ICollection<BaiDang> BaiDangs { get; set; }
        //public virtual ICollection<PhanHoi> PhanHois { get; set; }
    }
}