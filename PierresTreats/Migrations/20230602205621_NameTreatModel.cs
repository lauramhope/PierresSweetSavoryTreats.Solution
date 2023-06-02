using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PierresTreats.Migrations
{
    public partial class NameTreatModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TreatName",
                table: "Treats",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FlavorDescription",
                table: "Flavors",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Treats",
                newName: "TreatName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Flavors",
                newName: "FlavorDescription");
        }
    }
}
