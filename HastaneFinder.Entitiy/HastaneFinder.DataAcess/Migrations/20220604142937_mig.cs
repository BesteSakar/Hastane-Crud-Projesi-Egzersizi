using Microsoft.EntityFrameworkCore.Migrations;

namespace HastaneFinder.DataAcess.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hastaneler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isım = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Sehir = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    yatakSayısı = table.Column<int>(type: "int", nullable: false),
                    kurucusu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hastaneler", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hastaneler");
        }
    }
}
