using Microsoft.EntityFrameworkCore.Migrations;

namespace AcademiaFit.Infrastructure.Data.Migrations
{
    public partial class AddColumnAtivo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Recepcionistas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Professores",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Administradores",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Recepcionistas");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Administradores");
        }
    }
}
