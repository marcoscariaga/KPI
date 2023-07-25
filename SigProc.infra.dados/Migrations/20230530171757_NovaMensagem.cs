using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SigProc.infra.dados.Migrations
{
    /// <inheritdoc />
    public partial class NovaMensagem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mensagem",
                table: "ProcessoTramitacao");

            migrationBuilder.AddColumn<int>(
                name: "IdMensagem",
                table: "ProcessoTramitacao",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Mensagem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdGerencia = table.Column<int>(type: "int", nullable: false),
                    IdTramitacao = table.Column<int>(type: "int", nullable: true),
                    IdProcesso = table.Column<int>(type: "int", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEdicao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensagem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mensagem_Gerencia_IdGerencia",
                        column: x => x.IdGerencia,
                        principalTable: "Gerencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mensagem_ProcessoTramitacao_IdTramitacao",
                        column: x => x.IdTramitacao,
                        principalTable: "ProcessoTramitacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mensagem_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProcessoTramitacao_IdMensagem",
                table: "ProcessoTramitacao",
                column: "IdMensagem");

            migrationBuilder.CreateIndex(
                name: "IX_Mensagem_IdGerencia",
                table: "Mensagem",
                column: "IdGerencia");

            migrationBuilder.CreateIndex(
                name: "IX_Mensagem_IdTramitacao",
                table: "Mensagem",
                column: "IdTramitacao");

            migrationBuilder.CreateIndex(
                name: "IX_Mensagem_IdUsuario",
                table: "Mensagem",
                column: "IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessoTramitacao_Mensagem_IdMensagem",
                table: "ProcessoTramitacao",
                column: "IdMensagem",
                principalTable: "Mensagem",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProcessoTramitacao_Mensagem_IdMensagem",
                table: "ProcessoTramitacao");

            migrationBuilder.DropTable(
                name: "Mensagem");

            migrationBuilder.DropIndex(
                name: "IX_ProcessoTramitacao_IdMensagem",
                table: "ProcessoTramitacao");

            migrationBuilder.DropColumn(
                name: "IdMensagem",
                table: "ProcessoTramitacao");

            migrationBuilder.AddColumn<string>(
                name: "Mensagem",
                table: "ProcessoTramitacao",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
