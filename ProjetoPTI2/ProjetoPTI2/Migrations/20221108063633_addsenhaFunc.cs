using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoPTI2.Migrations
{
    public partial class addsenhaFunc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "tbFuncionario",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Senha",
                table: "tbFuncionario");
        }
    }
}
