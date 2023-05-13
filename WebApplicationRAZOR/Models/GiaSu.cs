//using MessagePack;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

//namespace PBL3_Project.Model
//{
//    public class GiaSu
//    {
//        [Key]
//        public int ID_GiaSu { get; set; }

//        [StringLength(50)]
//        [Required]
//        [Column(TypeName = "nvarchar")]
//        public string TenGiaSu { get; set; }

//        [StringLength(100)]
//        [Column(TypeName = "nvarchar")]
//        public string DiaChi { get; set; }

        
//        [Required]
//        [DataType(DataType.PhoneNumber)]
//        public string SoDienThoai { get; set; }

//        [DataType(DataType.EmailAddress)]
//        public string Email { get; set; }

//        public bool GioiTinh { get; set; }

//        [DataType(DataType.Text)]
//        public int Tuoi { get; set; }
//    }
//}
