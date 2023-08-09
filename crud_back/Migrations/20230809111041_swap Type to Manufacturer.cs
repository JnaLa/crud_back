using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace crud_back.Migrations
{
    /// <inheritdoc />
    public partial class swapTypetoManufacturer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Discs",
                newName: "Manufacturer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Manufacturer",
                table: "Discs",
                newName: "Type");
        }
    }
}
