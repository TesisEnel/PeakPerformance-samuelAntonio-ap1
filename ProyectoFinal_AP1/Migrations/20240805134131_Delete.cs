using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal_AP1.Migrations
{
    /// <inheritdoc />
    public partial class Delete : Migration
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

            migrationBuilder.AlterColumn<int>(
                name: "IdSuscripcion",
                table: "Usuarios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Suscripciones_IdSuscripcion",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_IdSuscripcion",
                table: "Usuarios");

            migrationBuilder.AlterColumn<int>(
                name: "IdSuscripcion",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdSuscripcion",
                table: "Usuarios",
                column: "IdSuscripcion",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Suscripciones_IdSuscripcion",
                table: "Usuarios",
                column: "IdSuscripcion",
                principalTable: "Suscripciones",
                principalColumn: "IdSuscripcion",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
