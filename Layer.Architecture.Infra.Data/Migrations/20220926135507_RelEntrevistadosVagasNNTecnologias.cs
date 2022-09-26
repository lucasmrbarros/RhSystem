using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Layer.Architecture.Infra.Data.Migrations
{
    public partial class RelEntrevistadosVagasNNTecnologias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntrevistadoNNTecnologias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    EntrevistadoId = table.Column<int>(type: "int", nullable: false),
                    TecId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntrevistadoNNTecnologias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntrevistadoNNTecnologias_Entrevistados_EntrevistadoId",
                        column: x => x.EntrevistadoId,
                        principalTable: "Entrevistados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntrevistadoNNTecnologias_Tecnologias_TecId",
                        column: x => x.TecId,
                        principalTable: "Tecnologias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VagaNNTecnologias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    VagaId = table.Column<int>(type: "int", nullable: false),
                    TecId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VagaNNTecnologias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VagaNNTecnologias_Tecnologias_TecId",
                        column: x => x.TecId,
                        principalTable: "Tecnologias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VagaNNTecnologias_vagas_VagaId",
                        column: x => x.VagaId,
                        principalTable: "vagas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EntrevistadoNNTecnologias_EntrevistadoId",
                table: "EntrevistadoNNTecnologias",
                column: "EntrevistadoId");

            migrationBuilder.CreateIndex(
                name: "IX_EntrevistadoNNTecnologias_TecId",
                table: "EntrevistadoNNTecnologias",
                column: "TecId");

            migrationBuilder.CreateIndex(
                name: "IX_VagaNNTecnologias_TecId",
                table: "VagaNNTecnologias",
                column: "TecId");

            migrationBuilder.CreateIndex(
                name: "IX_VagaNNTecnologias_VagaId",
                table: "VagaNNTecnologias",
                column: "VagaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntrevistadoNNTecnologias");

            migrationBuilder.DropTable(
                name: "VagaNNTecnologias");
        }
    }
}
