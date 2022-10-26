using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoPTI2.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "tbCliente",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Cnpj",
                table: "tbCliente",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Dt_cadastro",
                table: "tbCliente",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "tbCliente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "tbCliente",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoLogin",
                table: "tbCliente",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cnpj",
                table: "tbCliente");

            migrationBuilder.DropColumn(
                name: "Dt_cadastro",
                table: "tbCliente");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "tbCliente");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "tbCliente");

            migrationBuilder.DropColumn(
                name: "TipoLogin",
                table: "tbCliente");

            migrationBuilder.AlterColumn<int>(
                name: "Nome",
                table: "tbCliente",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
