using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Livros.Api.Migrations
{
    public partial class alteracao_autor_string : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Usuarios_UsuarioId",
                table: "Livros");

            migrationBuilder.DropIndex(
                name: "IX_Livros_UsuarioId",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Livros");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeNascimento",
                table: "Usuarios",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Autor",
                table: "Livros",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "DataDeNascimento",
                table: "Usuarios",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<int>(
                name: "Autor",
                table: "Livros",
                type: "int",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Livros",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Livros_UsuarioId",
                table: "Livros",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Usuarios_UsuarioId",
                table: "Livros",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }
    }
}
