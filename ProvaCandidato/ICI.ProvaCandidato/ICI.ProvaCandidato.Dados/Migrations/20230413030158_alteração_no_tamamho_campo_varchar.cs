using Microsoft.EntityFrameworkCore.Migrations;

namespace ICI.ProvaCandidato.Dados.Migrations
{
    public partial class alteração_no_tamamho_campo_varchar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Texto",
                table: "Noticia",
                type: "VARCHAR(8000)",
                maxLength: 8000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Texto",
                table: "Noticia",
                type: "VARCHAR",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(8000)",
                oldMaxLength: 8000,
                oldNullable: true);
        }
    }
}
