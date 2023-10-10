using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "estado",
                table: "Tarjetas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<double>(
                name: "MontoDeuda",
                table: "Tarjetas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "idClienteTitularid",
                table: "Tarjetas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "tipo",
                table: "Cuentas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "idClienteTitularid",
                table: "Cuentas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tarjetas_idClienteTitularid",
                table: "Tarjetas",
                column: "idClienteTitularid");

            migrationBuilder.CreateIndex(
                name: "IX_Cuentas_idClienteTitularid",
                table: "Cuentas",
                column: "idClienteTitularid");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuentas_Clientes_idClienteTitularid",
                table: "Cuentas",
                column: "idClienteTitularid",
                principalTable: "Clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjetas_Clientes_idClienteTitularid",
                table: "Tarjetas",
                column: "idClienteTitularid",
                principalTable: "Clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuentas_Clientes_idClienteTitularid",
                table: "Cuentas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarjetas_Clientes_idClienteTitularid",
                table: "Tarjetas");

            migrationBuilder.DropIndex(
                name: "IX_Tarjetas_idClienteTitularid",
                table: "Tarjetas");

            migrationBuilder.DropIndex(
                name: "IX_Cuentas_idClienteTitularid",
                table: "Cuentas");

            migrationBuilder.DropColumn(
                name: "MontoDeuda",
                table: "Tarjetas");

            migrationBuilder.DropColumn(
                name: "idClienteTitularid",
                table: "Tarjetas");

            migrationBuilder.DropColumn(
                name: "idClienteTitularid",
                table: "Cuentas");

            migrationBuilder.AlterColumn<string>(
                name: "estado",
                table: "Tarjetas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "tipo",
                table: "Cuentas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
