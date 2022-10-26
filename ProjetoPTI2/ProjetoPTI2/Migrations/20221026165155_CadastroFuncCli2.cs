using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoPTI2.Migrations
{
    public partial class CadastroFuncCli2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CadastroFuncionario",
                table: "CadastroFuncionario");

            migrationBuilder.RenameTable(
                name: "CadastroFuncionario",
                newName: "tbFuncionario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbFuncionario",
                table: "tbFuncionario",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tbFuncionario",
                table: "tbFuncionario");

            migrationBuilder.RenameTable(
                name: "tbFuncionario",
                newName: "CadastroFuncionario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CadastroFuncionario",
                table: "CadastroFuncionario",
                column: "Id");
        }
    }
}
