using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal_AP1.Migrations
{
    /// <inheritdoc />
    public partial class Ebtre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdEntrenador",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdEntrenador",
                table: "Usuarios",
                column: "IdEntrenador");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Entrenadores_IdEntrenador",
                table: "Usuarios",
                column: "IdEntrenador",
                principalTable: "Entrenadores",
                principalColumn: "IdEntrenador");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Entrenadores_IdEntrenador",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_IdEntrenador",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "IdEntrenador",
                table: "Usuarios");
        }
    }
}
