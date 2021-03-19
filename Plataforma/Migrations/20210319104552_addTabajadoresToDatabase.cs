using Microsoft.EntityFrameworkCore.Migrations;

namespace Plataforma.Migrations
{
    public partial class addTabajadoresToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Mestrabajador",
                table: "Trabajadores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mestrabajador",
                table: "Trabajadores");
        }
    }
}
