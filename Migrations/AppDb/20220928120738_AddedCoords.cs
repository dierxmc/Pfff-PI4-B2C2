using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pfff_PI4_B2C2.Migrations.AppDb
{
    public partial class AddedCoords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "xCoords",
                table: "Camera",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "yCoords",
                table: "Camera",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "xCoords",
                table: "Camera");

            migrationBuilder.DropColumn(
                name: "yCoords",
                table: "Camera");
        }
    }
}
