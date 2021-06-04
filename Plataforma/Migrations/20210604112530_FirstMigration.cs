using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plataforma.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Empresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre_Comercial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seguridad_social = table.Column<int>(type: "int", nullable: false),
                    Nif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Localidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DireccionComercial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPComercial = table.Column<int>(type: "int", nullable: false),
                    ProvinciaComercial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalidadComercial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CuentaCotizacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    convenio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    actividadprincial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNAE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Representacionlegal = table.Column<bool>(type: "bit", nullable: false),
                    nuevacreacion = table.Column<bool>(type: "bit", nullable: false),
                    creditodisponible = table.Column<int>(type: "int", nullable: false),
                    Banco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cuenta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    venta = table.Column<bool>(type: "bit", nullable: false),
                    Nombrereprensentante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Generorepresentante = table.Column<bool>(type: "bit", nullable: false),
                    nifrepresentante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fechafirma = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nombregestoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contatogestoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emailgestoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefonogestoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ano = table.Column<int>(type: "int", nullable: false),
                    Idcurso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaCurso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CursoNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEmpresa = table.Column<int>(type: "int", nullable: false),
                    Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Final = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaCurso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmpresasCurso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresasCurso", x => x.Id);
                });

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
                    AnoTrabajador = table.Column<int>(type: "int", nullable: false),
                    Mestrabajador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabajadores", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "EmpresaCurso");

            migrationBuilder.DropTable(
                name: "EmpresasCurso");

            migrationBuilder.DropTable(
                name: "Trabajadores");
        }
    }
}
