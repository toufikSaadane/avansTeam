using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace avansTeam.Migrations
{
    public partial class AddPricePersonToMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Movies",
                newName: "PriceSenior");

            migrationBuilder.AddColumn<double>(
                name: "PriceAdult",
                table: "Movies",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PriceChild",
                table: "Movies",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceAdult",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "PriceChild",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "PriceSenior",
                table: "Movies",
                newName: "Price");
        }
    }
}
