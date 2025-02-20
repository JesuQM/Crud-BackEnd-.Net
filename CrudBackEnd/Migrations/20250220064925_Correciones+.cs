using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudBackEnd.Migrations
{
    /// <inheritdoc />
    public partial class Correciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleFacturas_Facturas_FacturaId",
                table: "DetalleFacturas");

            migrationBuilder.DropIndex(
                name: "IX_DetalleFacturas_FacturaId",
                table: "DetalleFacturas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_DetalleFacturas_FacturaId",
                table: "DetalleFacturas",
                column: "FacturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleFacturas_Facturas_FacturaId",
                table: "DetalleFacturas",
                column: "FacturaId",
                principalTable: "Facturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
