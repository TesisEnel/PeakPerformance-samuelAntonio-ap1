using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal_AP1.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entrenadores",
                columns: table => new
                {
                    IdEntrenador = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Nivel = table.Column<string>(type: "TEXT", nullable: false),
                    Genero = table.Column<string>(type: "TEXT", nullable: false),
                    FotoPerfil = table.Column<byte[]>(type: "BLOB", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrenadores", x => x.IdEntrenador);
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    IdEquipo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false),
                    Foto = table.Column<byte[]>(type: "BLOB", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.IdEquipo);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    Stock = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<int>(type: "INTEGER", nullable: false),
                    Foto = table.Column<byte[]>(type: "BLOB", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdProducto);
                });

            migrationBuilder.CreateTable(
                name: "Suscripciones",
                columns: table => new
                {
                    IdSuscripcion = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Precio = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IdEntrenador = table.Column<int>(type: "INTEGER", nullable: true),
                    FotoPerfil = table.Column<byte[]>(type: "BLOB", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suscripciones", x => x.IdSuscripcion);
                    table.ForeignKey(
                        name: "FK_Suscripciones_Entrenadores_IdEntrenador",
                        column: x => x.IdEntrenador,
                        principalTable: "Entrenadores",
                        principalColumn: "IdEntrenador");
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Genero = table.Column<string>(type: "TEXT", nullable: true),
                    Correo = table.Column<string>(type: "TEXT", nullable: false),
                    Clave = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Codigo = table.Column<int>(type: "INTEGER", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Estado = table.Column<bool>(type: "INTEGER", nullable: false),
                    FotoPerfil = table.Column<byte[]>(type: "BLOB", nullable: false),
                    FechaInicioSuscripcion = table.Column<DateTime>(type: "TEXT", nullable: true),
                    FechaFinSuscripcion = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IdSuscripcion = table.Column<int>(type: "INTEGER", nullable: true),
                    SuscripcionIdSuscripcion = table.Column<int>(type: "INTEGER", nullable: true),
                    IdEntrenador = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Entrenadores_IdEntrenador",
                        column: x => x.IdEntrenador,
                        principalTable: "Entrenadores",
                        principalColumn: "IdEntrenador");
                    table.ForeignKey(
                        name: "FK_Usuarios_Suscripciones_SuscripcionIdSuscripcion",
                        column: x => x.SuscripcionIdSuscripcion,
                        principalTable: "Suscripciones",
                        principalColumn: "IdSuscripcion");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Suscripciones_IdEntrenador",
                table: "Suscripciones",
                column: "IdEntrenador");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdEntrenador",
                table: "Usuarios",
                column: "IdEntrenador");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_SuscripcionIdSuscripcion",
                table: "Usuarios",
                column: "SuscripcionIdSuscripcion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Suscripciones");

            migrationBuilder.DropTable(
                name: "Entrenadores");
        }
    }
}
