using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaHD.Migrations
{
    /// <inheritdoc />
    public partial class Compras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CantidadPantalones = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadPerfumes = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadSweater = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioPantalones = table.Column<decimal>(type: "TEXT", nullable: false),
                    PrecioPerfumes = table.Column<decimal>(type: "TEXT", nullable: false),
                    PrecioSweater = table.Column<decimal>(type: "TEXT", nullable: false),
                    PagoChofer = table.Column<decimal>(type: "TEXT", nullable: false),
                    PagoComidaChofer = table.Column<decimal>(type: "TEXT", nullable: false),
                    PagoGasolina = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.CompraId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compras");
        }
    }
}
