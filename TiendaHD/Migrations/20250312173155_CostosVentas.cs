using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaHD.Migrations
{
    /// <inheritdoc />
    public partial class CostosVentas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CostoVentas",
                columns: table => new
                {
                    CostoVentaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Costo = table.Column<decimal>(type: "TEXT", nullable: false),
                    Total = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostoVentas", x => x.CostoVentaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CostoVentas");
        }
    }
}
