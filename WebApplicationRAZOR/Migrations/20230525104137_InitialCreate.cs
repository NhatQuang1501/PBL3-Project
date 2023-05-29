using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PBL3_Project.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountGiaSu",
                columns: table => new
                {
                    ID_GiaSu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenAcc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordAcc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountGiaSu", x => x.ID_GiaSu);
                });

            migrationBuilder.CreateTable(
                name: "AccountPhuHuynh",
                columns: table => new
                {
                    ID_PhuHuynh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenAcc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordAcc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountPhuHuynh", x => x.ID_PhuHuynh);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountGiaSu");

            migrationBuilder.DropTable(
                name: "AccountPhuHuynh");
        }
    }
}
