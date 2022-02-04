using Microsoft.EntityFrameworkCore.Migrations;

namespace ProdajaMobilnihAplikacija.WebAPI.Migrations
{
    public partial class migi09 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Komentar",
                table: "MojSoftver");

            migrationBuilder.DropColumn(
                name: "Ocjena",
                table: "MojSoftver");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Komentar",
                table: "MojSoftver",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ocjena",
                table: "MojSoftver",
                type: "int",
                nullable: true);
        }
    }
}
