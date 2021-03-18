using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plataforma.Migrations
{
    public partial class AddTrabajadoresTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trabajadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrabajadorNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrabajadorNif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEmpresa = table.Column<int>(type: "int", nullable: false),
                    Fundae = table.Column<bool>(type: "bit", nullable: false),
                    SeguridadSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaTrabajador = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Trabajadortipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrabajadorAlta = table.Column<bool>(type: "bit", nullable: false),
                    AnoTrabajador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabajadores", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trabajadores");
        }
    }
}
