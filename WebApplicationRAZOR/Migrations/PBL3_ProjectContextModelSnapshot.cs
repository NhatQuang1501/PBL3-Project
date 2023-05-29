﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PBL3_Project.Data;

#nullable disable

namespace PBL3_Project.Migrations
{
    [DbContext(typeof(PBL3_ProjectContext))]
    partial class PBL3_ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PBL3_Project.Models.AccountGiaSu", b =>
                {
                    b.Property<int>("ID_GiaSu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_GiaSu"), 1L, 1);

                    b.Property<string>("PasswordAcc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenAcc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_GiaSu");

                    b.ToTable("AccountGiaSu");
                });

            modelBuilder.Entity("PBL3_Project.Models.AccountPhuHuynh", b =>
                {
                    b.Property<int>("ID_PhuHuynh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_PhuHuynh"), 1L, 1);

                    b.Property<string>("PasswordAcc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenAcc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_PhuHuynh");

                    b.ToTable("AccountPhuHuynh");
                });
#pragma warning restore 612, 618
        }
    }
}
