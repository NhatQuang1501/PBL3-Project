using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Models;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace PBL3_Project.Pages.Admin.QLPost
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }

        //public IActionResult MyPage()
        //{
        //    var connectionString = "Data Source=NHATQUANG;Initial Catalog=GIASU;Integrated Security=True";
        //    var list = new List<BaiDang>();
        //    using (var connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        using (var command = new SqlCommand("SELECT * FROM BaiDang", connection))
        //        {
        //            using (var reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    var obj = new BaiDang();
        //                    obj.ID_BaiDang = reader.GetInt32(0);
        //                    obj.TrinhDoHocVan = reader.GetString(1);
        //                    obj.MonHoc = reader.GetString(2);
        //                    obj.HocPhi = reader.GetInt32(0);
        //                    obj.Lop = reader.GetString(3);
        //                    obj.SoBuoi = reader.GetInt32(0);
        //                    obj.SoHocVien = reader.GetInt32(0);
        //                    obj.ThoiGian = reader.GetString(4);
        //                    obj.DiaChi = reader.GetString(5);

        //                    list.Add(obj);
        //                }
        //            }
        //        }
        //    }
        //    //ViewBag.Data = list;
        //    //return View();
        //}

    }
}
