using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AALEKH_SOCIETY_COOP.Migrations
{
    public partial class FixedCharges1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cleaningcharges",
                table: "FixedCharges");

            migrationBuilder.DropColumn(
                name: "Developmentcharges",
                table: "FixedCharges");

            migrationBuilder.DropColumn(
                name: "Maintainencecharges",
                table: "FixedCharges");

            migrationBuilder.RenameColumn(
                name: "Transferfees",
                table: "FixedCharges",
                newName: "FixedCharge");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "FixedCharges",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Updatedon",
                table: "FixedCharges",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "FixedCharges");

            migrationBuilder.DropColumn(
                name: "Updatedon",
                table: "FixedCharges");

            migrationBuilder.RenameColumn(
                name: "FixedCharge",
                table: "FixedCharges",
                newName: "Transferfees");

            migrationBuilder.AddColumn<int>(
                name: "Cleaningcharges",
                table: "FixedCharges",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Developmentcharges",
                table: "FixedCharges",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Maintainencecharges",
                table: "FixedCharges",
                type: "int",
                nullable: true);
        }
    }
}
