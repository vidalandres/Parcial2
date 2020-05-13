using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SegundoParcial.Migrations
{
    public partial class Covid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apoyos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Persona = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    Valor = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apoyos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Identificacion = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    Departamento = table.Column<string>(nullable: true),
                    Ciudad = table.Column<string>(nullable: true),
                    Acumulado = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Identificacion);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apoyos");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
