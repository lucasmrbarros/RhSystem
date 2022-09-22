using Microsoft.EntityFrameworkCore.Migrations;

namespace Layer.Architecture.Infra.Data.Migrations
{
    public partial class vaga_entrevistado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VagaId",
                table: "Entrevistados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Entrevistados_VagaId",
                table: "Entrevistados",
                column: "VagaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrevistados_vagas_VagaId",
                table: "Entrevistados",
                column: "VagaId",
                principalTable: "vagas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrevistados_vagas_VagaId",
                table: "Entrevistados");

            migrationBuilder.DropIndex(
                name: "IX_Entrevistados_VagaId",
                table: "Entrevistados");

            migrationBuilder.DropColumn(
                name: "VagaId",
                table: "Entrevistados");
        }
    }
}
