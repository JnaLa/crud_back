using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace crud_back.Migrations
{
    /// <inheritdoc />
    public partial class addedcolorfieldtodiscmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Discs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Discs");
        }
    }
}
