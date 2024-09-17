using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Livros.Api.Migrations
{
    public partial class Addcamposnomodellivro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Autor",
                table: "Livros",
                type: "int",
                maxLength: 100,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Imagem",
                table: "Livros",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Autor",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Livros");
        }
    }
}
