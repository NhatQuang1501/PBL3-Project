﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<PBL3_Project.Models.HoSoGiaSu> HoSoGiaSu { get; set; } = default!;

        public DbSet<PBL3_Project.Models.HoSoPhuHuynh>? HoSoPhuHuynh { get; set; }

        public DbSet<PBL3_Project.Models.BaiDang>? BaiDang { get; set; }
        public DbSet<PBL3_Project.Models.PhanHoi>? PhanHoi { get; set; }
        public DbSet<PBL3_Project.Models.SuatDayDangKi>? SuatDayDangKi { get; set; }
        public DbSet<PBL3_Project.Models.SuatDayDaNhan>? SuatDayDaNhan { get; set; }

    }
}
