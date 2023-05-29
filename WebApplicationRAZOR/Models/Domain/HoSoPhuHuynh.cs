using System.ComponentModel.DataAnnotations;

namespace PBL3_Project.Models.Domain
{
    public class HoSoPhuHuynh
    {
        [Key]
        public int ID_PhuHuynh { get; set; }
        public string TenPhuHuynh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public bool GioiTinh { get; set; }
        public int Tuoi { get; set; }

    }
}
