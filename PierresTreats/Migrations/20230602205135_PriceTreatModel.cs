using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PierresTreats.Migrations
{
    public partial class PriceTreatModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TreatPrice",
                table: "Treats",
                newName: "Price");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Treats",
                newName: "TreatPrice");
        }
    }
}
