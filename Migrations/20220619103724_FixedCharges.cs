using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AALEKH_SOCIETY_COOP.Migrations
{
    public partial class FixedCharges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FixedCharges",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Maintainencecharges = table.Column<int>(type: "int", nullable: true),
                    Cleaningcharges = table.Column<int>(type: "int", nullable: true),
                    Developmentcharges = table.Column<int>(type: "int", nullable: true),
                    Transferfees = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixedCharges", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FixedCharges");
        }
    }
}
