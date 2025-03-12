using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaHD.Migrations
{
    /// <inheritdoc />
    public partial class GastosMenores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GastosMenores",
                columns: table => new
                {
                    GastosMId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GastosMName = table.Column<string>(type: "TEXT", nullable: false),
                    ValorGastosM = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GastosMenores", x => x.GastosMId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GastosMenores");
        }
    }
}
