using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SigProc.infra.dados.Migrations
{
    /// <inheritdoc />
    public partial class ProcessoTramitacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProcessoTramitacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProcesso = table.Column<int>(type: "int", nullable: false),
                    IdOrgaoOrigem = table.Column<int>(type: "int", nullable: false),
                    IdOrgaoDestino = table.Column<int>(type: "int", nullable: false),
                    Prazo = table.Column<int>(type: "int", nullable: false),
                    DataTramitacao = table.Column<DateTime>(type: "date", nullable: false),
                    DataPrazo = table.Column<DateTime>(type: "date", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUsuarioTramitacao = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEdicao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessoTramitacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcessoTramitacao_Gerencia_IdOrgaoDestino",
                        column: x => x.IdOrgaoDestino,
                        principalTable: "Gerencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProcessoTramitacao_Processo_IdProcesso",
                        column: x => x.IdProcesso,
                        principalTable: "Processo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProcessoTramitacao_IdOrgaoDestino",
                table: "ProcessoTramitacao",
                column: "IdOrgaoDestino");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessoTramitacao_IdProcesso",
                table: "ProcessoTramitacao",
                column: "IdProcesso");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProcessoTramitacao");
        }
    }
}
