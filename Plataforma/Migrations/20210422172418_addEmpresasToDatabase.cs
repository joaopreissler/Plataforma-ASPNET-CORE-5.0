using Microsoft.EntityFrameworkCore.Migrations;

namespace Plataforma.Migrations
{
    public partial class addEmpresasToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "seguridad_social",
                table: "Empresa",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "seguridad_social",
                table: "Empresa");
        }
    }
}
