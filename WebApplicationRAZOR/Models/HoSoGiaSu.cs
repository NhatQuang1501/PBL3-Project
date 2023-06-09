﻿using System.ComponentModel.DataAnnotations;

namespace PBL3_Project.Models
{
	public class HoSoGiaSu
	{
		[Key]
		public int ID_GiaSu { get; set; }
        public string TenAcc { get; set; }
        public string PasswordAcc { get; set; }
        public string TenGiaSu { get; set; }
		public string DiaChi { get; set; }
		public string SoDienThoai { get; set; }
		public string Email { get; set; }
		public bool GioiTinh { get; set; }
		public int Tuoi { get; set; }
		public string MonHoc { get; set; }
		public string TrinhDoHocVan { get; set; }
		public int HocPhi{ get; set; }
	}
}
