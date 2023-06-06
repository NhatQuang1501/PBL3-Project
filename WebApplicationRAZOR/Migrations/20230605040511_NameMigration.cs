using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PBL3_Project.Migrations
{
    public partial class NameMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HoSoGiaSu",
                columns: table => new
                {
                    ID_GiaSu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenAcc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordAcc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenGiaSu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    Tuoi = table.Column<int>(type: "int", nullable: false),
                    MonHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrinhDoHocVan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HocPhi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoSoGiaSu", x => x.ID_GiaSu);
                });

            migrationBuilder.CreateTable(
                name: "HoSoPhuHuynh",
                columns: table => new
                {
                    ID_PhuHuynh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenAcc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordAcc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenPhuHuynh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    Tuoi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoSoPhuHuynh", x => x.ID_PhuHuynh);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoSoGiaSu");

            migrationBuilder.DropTable(
                name: "HoSoPhuHuynh");
        }
    }
}
