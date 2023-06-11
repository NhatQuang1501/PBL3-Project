﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PBL3_Project.Data;

#nullable disable

namespace PBL3_Project.Migrations
{
    [DbContext(typeof(PBL3_ProjectContext))]
    [Migration("20230608191410_NameMigration")]
    partial class NameMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PBL3_Project.Models.BaiDang", b =>
                {
                    b.Property<int?>("ID_BaiDang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ID_BaiDang"), 1L, 1);

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HocPhi")
                        .HasColumnType("int");

                    b.Property<int>("ID_PhuHuynh")
                        .HasColumnType("int");

                    b.Property<string>("Lop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MonHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoBuoi")
                        .HasColumnType("int");

                    b.Property<int>("SoHocVien")
                        .HasColumnType("int");

                    b.Property<string>("ThoiGian")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TinhTrang")
                        .HasColumnType("bit");

                    b.Property<bool>("TinhTrangDuyet")
                        .HasColumnType("bit");

                    b.Property<string>("TrinhDoHocVan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_BaiDang");

                    b.ToTable("BaiDang");
                });

            modelBuilder.Entity("PBL3_Project.Models.HoSoGiaSu", b =>
                {
                    b.Property<int?>("ID_GiaSu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ID_GiaSu"), 1L, 1);

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<int>("HocPhi")
                        .HasColumnType("int");

                    b.Property<string>("MonHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordAcc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenAcc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenGiaSu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrinhDoHocVan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_GiaSu");

                    b.ToTable("HoSoGiaSu");
                });

            modelBuilder.Entity("PBL3_Project.Models.HoSoPhuHuynh", b =>
                {
                    b.Property<int?>("ID_PhuHuynh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ID_PhuHuynh"), 1L, 1);

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordAcc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenAcc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenPhuHuynh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_PhuHuynh");

                    b.ToTable("HoSoPhuHuynh");
                });
#pragma warning restore 612, 618
        }
    }
}
