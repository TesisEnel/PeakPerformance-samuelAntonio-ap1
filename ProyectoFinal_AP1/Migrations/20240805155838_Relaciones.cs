using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal_AP1.Migrations
{
    /// <inheritdoc />
    public partial class Relaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Suscripciones_IdSuscripcion",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_IdSuscripcion",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "SuscripcionIdSuscripcion",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_SuscripcionIdSuscripcion",
                table: "Usuarios",
                column: "SuscripcionIdSuscripcion");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Suscripciones_SuscripcionIdSuscripcion",
                table: "Usuarios",
                column: "SuscripcionIdSuscripcion",
                principalTable: "Suscripciones",
                principalColumn: "IdSuscripcion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Suscripciones_SuscripcionIdSuscripcion",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_SuscripcionIdSuscripcion",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "SuscripcionIdSuscripcion",
                table: "Usuarios");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdSuscripcion",
                table: "Usuarios",
                column: "IdSuscripcion",
                unique: true,
                filter: "[IdSuscripcion] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Suscripciones_IdSuscripcion",
                table: "Usuarios",
                column: "IdSuscripcion",
                principalTable: "Suscripciones",
                principalColumn: "IdSuscripcion");
        }
    }
}
