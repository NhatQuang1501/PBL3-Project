using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PBL3_Project.Models;

namespace PBL3_Project.Data
{
    public class PBL3_ProjectContext : DbContext
    {
        public PBL3_ProjectContext (DbContextOptions<PBL3_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<BaiDang> BaiDang { get; set; }
        public DbSet<HoSoGiaSu> HoSoGiaSu { get; set; }
        public DbSet<HoSoPhuHuynh> HoSoPhuHuynh { get; set; }
        public DbSet<PhanHoi> PhanHoi { get; set; }
        public DbSet<SuatDayDangKi> SuatDayDangKi { get; set; }
        public DbSet<SuatDayDaNhan> SuatDayDaNhan { get; set; }
    }
}
