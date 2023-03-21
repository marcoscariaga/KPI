using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SigProc.infra.dados.Migrations
{
    /// <inheritdoc />
    public partial class prazo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoPrazo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEdicao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPrazo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GerenciaPrazo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdGerencia = table.Column<int>(type: "int", nullable: false),
                    IdTipoPrazo = table.Column<int>(type: "int", nullable: false),
                    IdTipoContratacao = table.Column<int>(type: "int", nullable: false),
                    IdTipoProcesso = table.Column<int>(type: "int", nullable: false),
                    Prazo = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioCadastro = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEdicao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GerenciaPrazo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GerenciaPrazo_Gerencia_IdGerencia",
                        column: x => x.IdGerencia,
                        principalTable: "Gerencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GerenciaPrazo_TipoContratacao_IdTipoContratacao",
                        column: x => x.IdTipoContratacao,
                        principalTable: "TipoContratacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GerenciaPrazo_TipoPrazo_IdTipoPrazo",
                        column: x => x.IdTipoPrazo,
                        principalTable: "TipoPrazo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GerenciaPrazo_TipoProcesso_IdTipoProcesso",
                        column: x => x.IdTipoProcesso,
                        principalTable: "TipoProcesso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GerenciaPrazo_IdGerencia",
                table: "GerenciaPrazo",
                column: "IdGerencia");

            migrationBuilder.CreateIndex(
                name: "IX_GerenciaPrazo_IdTipoContratacao",
                table: "GerenciaPrazo",
                column: "IdTipoContratacao");

            migrationBuilder.CreateIndex(
                name: "IX_GerenciaPrazo_IdTipoPrazo",
                table: "GerenciaPrazo",
                column: "IdTipoPrazo");

            migrationBuilder.CreateIndex(
                name: "IX_GerenciaPrazo_IdTipoProcesso",
                table: "GerenciaPrazo",
                column: "IdTipoProcesso");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GerenciaPrazo");

            migrationBuilder.DropTable(
                name: "TipoPrazo");
        }
    }
}
