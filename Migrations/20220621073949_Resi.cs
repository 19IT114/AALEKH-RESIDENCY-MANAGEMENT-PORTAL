using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AALEKH_SOCIETY_COOP.Migrations
{
    public partial class Resi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id",
                table: "Residents");

            migrationBuilder.RenameColumn(
                name: "Isa_Streetmember",
                table: "Residents",
                newName: "Is_a_Streetmember");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Is_a_Streetmember",
                table: "Residents",
                newName: "Isa_Streetmember");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Residents",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
