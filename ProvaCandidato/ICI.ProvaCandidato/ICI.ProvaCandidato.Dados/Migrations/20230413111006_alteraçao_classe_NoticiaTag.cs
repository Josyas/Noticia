using Microsoft.EntityFrameworkCore.Migrations;

namespace ICI.ProvaCandidato.Dados.Migrations
{
    public partial class alteraçao_classe_NoticiaTag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdNoticia",
                table: "NoticiaTag",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdNoticia",
                table: "NoticiaTag",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
