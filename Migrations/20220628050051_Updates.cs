using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AALEKH_SOCIETY_COOP.Migrations
{
    public partial class Updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Residents",
                table: "Residents");

            migrationBuilder.AlterColumn<string>(
                name: "Block_no",
                table: "Residents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Residents",
                table: "Residents",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Residents",
                table: "Residents");

            migrationBuilder.AlterColumn<string>(
                name: "Block_no",
                table: "Residents",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Residents",
                table: "Residents",
                column: "Block_no");
        }
    }
}
