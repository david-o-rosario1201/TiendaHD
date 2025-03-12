using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaHD.Migrations
{
    /// <inheritdoc />
    public partial class Poblacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Poblacion",
                columns: table => new
                {
                    PoblacionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PoblacionTotal = table.Column<int>(type: "INTEGER", nullable: false),
                    PoblacionCompradora = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poblacion", x => x.PoblacionId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Poblacion");
        }
    }
}
