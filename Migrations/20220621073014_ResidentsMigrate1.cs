using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AALEKH_SOCIETY_COOP.Migrations
{
    public partial class ResidentsMigrate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Residents",
                columns: table => new
                {
                    Block_no = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false),
                    Owner_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile_no = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isa_Streetmember = table.Column<bool>(type: "bit", nullable: false),
                    has_Rentals = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residents", x => x.Block_no);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Residents");
        }
    }
}
