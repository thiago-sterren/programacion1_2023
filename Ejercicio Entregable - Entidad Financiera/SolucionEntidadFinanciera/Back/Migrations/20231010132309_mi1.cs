using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class mi1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idCuentaBancariaid",
                table: "Tarjetas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tarjetas_idCuentaBancariaid",
                table: "Tarjetas",
                column: "idCuentaBancariaid");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjetas_Cuentas_idCuentaBancariaid",
                table: "Tarjetas",
                column: "idCuentaBancariaid",
                principalTable: "Cuentas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarjetas_Cuentas_idCuentaBancariaid",
                table: "Tarjetas");

            migrationBuilder.DropIndex(
                name: "IX_Tarjetas_idCuentaBancariaid",
                table: "Tarjetas");

            migrationBuilder.DropColumn(
                name: "idCuentaBancariaid",
                table: "Tarjetas");
        }
    }
}
