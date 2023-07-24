using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace crud_back.Migrations
{
    /// <inheritdoc />
    public partial class PuttingPractiseModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Practises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C1Short = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C1Medium = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C1Long = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C2Short = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C2Medium = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C2Long = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Practises", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Practises");
        }
    }
}
