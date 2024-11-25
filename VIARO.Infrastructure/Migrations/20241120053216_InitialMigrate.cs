using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VIARO.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "alumno_grado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlumnoId = table.Column<int>(type: "int", nullable: false),
                    GradoId = table.Column<int>(type: "int", nullable: false),
                    Seccion = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alumno_grado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "alumnos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(76)", maxLength: 76, nullable: false),
                    Apellidos = table.Column<string>(type: "varchar(76)", maxLength: 76, nullable: false),
                    Genero = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alumnos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "grados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfesorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "profesores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(76)", maxLength: 76, nullable: false),
                    Apellidos = table.Column<string>(type: "varchar(76)", maxLength: 76, nullable: false),
                    Genero = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profesores", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alumno_grado");

            migrationBuilder.DropTable(
                name: "alumnos");

            migrationBuilder.DropTable(
                name: "grados");

            migrationBuilder.DropTable(
                name: "profesores");
        }
    }
}
