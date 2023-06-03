using Microsoft.EntityFrameworkCore;
using PBL3_Project.Data;

namespace PBL3_Project.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PBL3_ProjectContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PBL3_ProjectContext>>()))
            {
                if (context == null || context.HoSoGiaSu == null)
                {
                    throw new ArgumentNullException("Null PBL3_ProjectContext");
                }

                // Look for any movies.
                if (context.HoSoGiaSu.Any())
                {
                    return;   // DB has been seeded
                }

                context.HoSoGiaSu.AddRange(
                    new HoSoGiaSu
                    {
                        ID_GiaSu = 1,
                        TenAcc = "giasu1",
                        PasswordAcc = "giasu1",
                        TenGiaSu = "Nguyễn Nhật Quang",
                        MonHoc = "Toán",
                        TrinhDoHocVan = "Sinh viên",
                        HocPhi = 500000,
                        GioiTinh = true,
                        Tuoi = 20,
                        DiaChi = "130 Nguyễn Chánh",
                        SoDienThoai = "0812301052",
                        Email = "nhatquang1512003@gmail.com"        
                    },

                    new HoSoGiaSu
                    {
                       // ID_GiaSu = 2,
                        TenAcc = "giasu2",
                        PasswordAcc = "giasu2",
                        TenGiaSu = "Hoàng Thị Hồng Thắm",
                        MonHoc = "Tiếng Anh",
                        TrinhDoHocVan = "Giáo viên",
                        HocPhi = 100000,
                        GioiTinh = false,
                        Tuoi = 15,
                        DiaChi = "562 Điện Biên Phủ",
                        SoDienThoai = "0951236478",
                        Email = "hththam@gmail.com"
                    },

                    new HoSoGiaSu
                    {
                      //  ID_GiaSu = 3,
                        TenAcc = "giasu3",
                        PasswordAcc = "giasu3",
                        TenGiaSu = "Bùi Anh Vũ",
                        MonHoc = "Tiếng Nhật",
                        TrinhDoHocVan = "Sinh viên",
                        HocPhi = 700000,
                        GioiTinh = true,
                        Tuoi = 25,
                        DiaChi = "37 Trung Nghĩa 4",
                        SoDienThoai = "0123456789",
                        Email = "buianhvu226@gmail.com"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
