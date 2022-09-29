using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Layer.Architecture.Infra.Data.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tecnologias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnologias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "vagas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Salario = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vagas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entrevistados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Telefone = table.Column<string>(type: "text", nullable: true),
                    VagaId = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrevistados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entrevistados_vagas_VagaId",
                        column: x => x.VagaId,
                        principalTable: "vagas",
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
                    Pontos = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_entrevistadoNNTecnologias_EntrevistadoId",
                table: "entrevistadoNNTecnologias",
                column: "EntrevistadoId");

            migrationBuilder.CreateIndex(
                name: "IX_entrevistadoNNTecnologias_TecId",
                table: "entrevistadoNNTecnologias",
                column: "TecId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrevistados_VagaId",
                table: "Entrevistados",
                column: "VagaId");

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

            migrationBuilder.DropTable(
                name: "Entrevistados");

            migrationBuilder.DropTable(
                name: "Tecnologias");

            migrationBuilder.DropTable(
                name: "vagas");
        }
    }
}
