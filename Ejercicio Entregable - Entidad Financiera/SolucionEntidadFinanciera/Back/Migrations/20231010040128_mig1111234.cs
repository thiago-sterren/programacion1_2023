using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class mig1111234 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cantidadTarjetas",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cantidadTarjetas",
                table: "Clientes");
        }
    }
}
