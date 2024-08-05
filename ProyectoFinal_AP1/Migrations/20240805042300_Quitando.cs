using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal_AP1.Migrations
{
    /// <inheritdoc />
    public partial class Quitando : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Entrenadores_EntrenadorId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_EntrenadorId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "EntrenadorId",
                table: "Usuarios");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EntrenadorId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EntrenadorId",
                table: "Usuarios",
                column: "EntrenadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Entrenadores_EntrenadorId",
                table: "Usuarios",
                column: "EntrenadorId",
                principalTable: "Entrenadores",
                principalColumn: "IdEntrenador");
        }
    }
}
