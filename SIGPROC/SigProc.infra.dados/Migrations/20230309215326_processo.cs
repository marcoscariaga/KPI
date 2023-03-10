using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SigProc.infra.dados.Migrations
{
    /// <inheritdoc />
    public partial class processo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gerencia_Usuario_UsuarioId",
                table: "Gerencia");

            migrationBuilder.DropColumn(
                name: "Id_Responsavel",
                table: "Gerencia");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Gerencia",
                newName: "IdUsuarioResp");

            migrationBuilder.RenameIndex(
                name: "IX_Gerencia_UsuarioId",
                table: "Gerencia",
                newName: "IX_Gerencia_IdUsuarioResp");

            migrationBuilder.CreateTable(
                name: "Processo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumProcesso = table.Column<int>(type: "int", nullable: false),
                    Requerente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Assunto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoDoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumDoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCadastroProc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataUltimaTramProc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgaoCadastro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgaoOrigem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgaoDestino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfComplementar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prioridade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdTipoContratacao = table.Column<int>(type: "int", nullable: false),
                    IdTipoProcesso = table.Column<int>(type: "int", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUsuarioCadastro = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    TipoContratacaoId = table.Column<int>(type: "int", nullable: false),
                    TipoProcessoId = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEdicao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Processo_TipoContratacao_TipoContratacaoId",
                        column: x => x.TipoContratacaoId,
                        principalTable: "TipoContratacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Processo_TipoProcesso_TipoProcessoId",
                        column: x => x.TipoProcessoId,
                        principalTable: "TipoProcesso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Processo_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Processo_TipoContratacaoId",
                table: "Processo",
                column: "TipoContratacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Processo_TipoProcessoId",
                table: "Processo",
                column: "TipoProcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_Processo_UsuarioId",
                table: "Processo",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gerencia_Usuario_IdUsuarioResp",
                table: "Gerencia",
                column: "IdUsuarioResp",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gerencia_Usuario_IdUsuarioResp",
                table: "Gerencia");

            migrationBuilder.DropTable(
                name: "Processo");

            migrationBuilder.RenameColumn(
                name: "IdUsuarioResp",
                table: "Gerencia",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Gerencia_IdUsuarioResp",
                table: "Gerencia",
                newName: "IX_Gerencia_UsuarioId");

            migrationBuilder.AddColumn<int>(
                name: "Id_Responsavel",
                table: "Gerencia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Gerencia_Usuario_UsuarioId",
                table: "Gerencia",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
