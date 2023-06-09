using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBL3_Project.Data;
using PBL3_Project.Models;

namespace PBL3_Project.Pages.Admin
{
    //[Authorize(Roles = $"{RolesApp.Admin}")]
    public class QLPInfoModel : PageModel
    {

        private readonly PBL3_ProjectContext dBContext;

        [BindProperty]
        public HoSoPhuHuynh HoSoPhuHuynh { get; set; }

        public QLPInfoModel(PBL3_ProjectContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public void OnGet(int id)
        {
            HoSoPhuHuynh = dBContext.HoSoPhuHuynh.Find(id);
        }
        //public IActionResult OnPostEdit()
        //{
        //    var existingHoso = dBContext.HoSoPhuHuynh.Find(HoSoPhuHuynh.ID_PhuHuynh);
        //    if (existingHoso != null)
        //    {
        //        existingHoso.TenPhuHuynh = HoSoPhuHuynh.TenPhuHuynh;
        //        existingHoso.DiaChi = HoSoPhuHuynh.DiaChi;
        //        existingHoso.NgaySinh= HoSoPhuHuynh.NgaySinh;
        //        existingHoso.SoDienThoai= HoSoPhuHuynh.SoDienThoai;
        //    }
        //    dBContext.SaveChanges();
        //    return RedirectToPage("/admin/qlphoso");
        //}

        public IActionResult OnPostDelete()
        {
            var existingHoso = dBContext.HoSoPhuHuynh.Find(HoSoPhuHuynh.ID_PhuHuynh);
            if (existingHoso != null)
            {
                dBContext.HoSoPhuHuynh.Remove(existingHoso);
                dBContext.SaveChanges();
            }
            return RedirectToPage("/admin/qlphoso");
        }


    }
}
