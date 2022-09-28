using Microsoft.EntityFrameworkCore.Migrations;

namespace Layer.Architecture.Infra.Data.Migrations
{
    public partial class addPontosDeVaga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Pontos",
                table: "vagaNNTecnologias",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pontos",
                table: "vagaNNTecnologias");
        }
    }
}
