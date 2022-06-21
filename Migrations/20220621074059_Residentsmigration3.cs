using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AALEKH_SOCIETY_COOP.Migrations
{
    public partial class Residentsmigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Residents",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Residents");
        }
    }
}
