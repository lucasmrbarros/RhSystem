using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Layer.Architecture.Infra.Data.Migrations
{
    public partial class RelEntrevistadosVagasNNTecnologias2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "entrevistadoNNTecnologias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    EntrevistadoId = table.Column<int>(type: "int", nullable: false),
                    TecId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entrevistadoNNTecnologias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_entrevistadoNNTecnologias_Entrevistados_EntrevistadoId",
                        column: x => x.EntrevistadoId,
                        principalTable: "Entrevistados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_entrevistadoNNTecnologias_Tecnologias_TecId",
                        column: x => x.TecId,
                        principalTable: "Tecnologias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vagaNNTecnologias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    VagaId = table.Column<int>(type: "int", nullable: false),
                    TecId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vagaNNTecnologias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_vagaNNTecnologias_Tecnologias_TecId",
                        column: x => x.TecId,
                        principalTable: "Tecnologias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vagaNNTecnologias_vagas_VagaId",
                        column: x => x.VagaId,
                        principalTable: "vagas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_entrevistadoNNTecnologias_EntrevistadoId",
                table: "entrevistadoNNTecnologias",
                column: "EntrevistadoId");

            migrationBuilder.CreateIndex(
                name: "IX_entrevistadoNNTecnologias_TecId",
                table: "entrevistadoNNTecnologias",
                column: "TecId");

            migrationBuilder.CreateIndex(
                name: "IX_vagaNNTecnologias_TecId",
                table: "vagaNNTecnologias",
                column: "TecId");

            migrationBuilder.CreateIndex(
                name: "IX_vagaNNTecnologias_VagaId",
                table: "vagaNNTecnologias",
                column: "VagaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "entrevistadoNNTecnologias");

            migrationBuilder.DropTable(
                name: "vagaNNTecnologias");
        }
    }
}
