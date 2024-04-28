using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wypoz_ASP.Data.Migrations
{
    /// <inheritdoc />
    public partial class changeAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdresKodPocztowy",
                table: "RentalPoints");

            migrationBuilder.DropColumn(
                name: "AdresKodPocztowy",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "AdresUlica",
                table: "RentalPoints",
                newName: "AddressStreet");

            migrationBuilder.RenameColumn(
                name: "AdresNumerMieszkania",
                table: "RentalPoints",
                newName: "AddressPostalCode");

            migrationBuilder.RenameColumn(
                name: "AdresNumerDomu",
                table: "RentalPoints",
                newName: "AddressHouseNumber");

            migrationBuilder.RenameColumn(
                name: "AdresMiasto",
                table: "RentalPoints",
                newName: "AddressCity");

            migrationBuilder.RenameColumn(
                name: "AdresUlica",
                table: "AspNetUsers",
                newName: "AddressStreet");

            migrationBuilder.RenameColumn(
                name: "AdresNumerMieszkania",
                table: "AspNetUsers",
                newName: "AddressPostalCode");

            migrationBuilder.RenameColumn(
                name: "AdresNumerDomu",
                table: "AspNetUsers",
                newName: "AddressHouseNumber");

            migrationBuilder.RenameColumn(
                name: "AdresMiasto",
                table: "AspNetUsers",
                newName: "AddressCity");

            migrationBuilder.AddColumn<string>(
                name: "AddressFlatNumber",
                table: "RentalPoints",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressFlatNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressFlatNumber",
                table: "RentalPoints");

            migrationBuilder.DropColumn(
                name: "AddressFlatNumber",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "AddressStreet",
                table: "RentalPoints",
                newName: "AdresUlica");

            migrationBuilder.RenameColumn(
                name: "AddressPostalCode",
                table: "RentalPoints",
                newName: "AdresNumerMieszkania");

            migrationBuilder.RenameColumn(
                name: "AddressHouseNumber",
                table: "RentalPoints",
                newName: "AdresNumerDomu");

            migrationBuilder.RenameColumn(
                name: "AddressCity",
                table: "RentalPoints",
                newName: "AdresMiasto");

            migrationBuilder.RenameColumn(
                name: "AddressStreet",
                table: "AspNetUsers",
                newName: "AdresUlica");

            migrationBuilder.RenameColumn(
                name: "AddressPostalCode",
                table: "AspNetUsers",
                newName: "AdresNumerMieszkania");

            migrationBuilder.RenameColumn(
                name: "AddressHouseNumber",
                table: "AspNetUsers",
                newName: "AdresNumerDomu");

            migrationBuilder.RenameColumn(
                name: "AddressCity",
                table: "AspNetUsers",
                newName: "AdresMiasto");

            migrationBuilder.AddColumn<string>(
                name: "AdresKodPocztowy",
                table: "RentalPoints",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdresKodPocztowy",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
