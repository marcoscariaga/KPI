using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SigProc.infra.dados.Migrations
{
    /// <inheritdoc />
    public partial class GerenciaUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoUsuarioGerencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEdicao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUsuarioGerencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GerenciaUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdGerencia = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioGerencia = table.Column<int>(type: "int", nullable: false),
                    IdTipoUsuarioGerencia = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioCadastro = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEdicao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GerenciaUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GerenciaUsuario_Gerencia_IdGerencia",
                        column: x => x.IdGerencia,
                        principalTable: "Gerencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_GerenciaUsuario_TipoUsuarioGerencia_IdTipoUsuarioGerencia",
                        column: x => x.IdTipoUsuarioGerencia,
                        principalTable: "TipoUsuarioGerencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_GerenciaUsuario_Usuario_IdUsuarioCadastro",
                        column: x => x.IdUsuarioCadastro,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_GerenciaUsuario_Usuario_IdUsuarioGerencia",
                        column: x => x.IdUsuarioGerencia,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GerenciaUsuario_IdGerencia",
                table: "GerenciaUsuario",
                column: "IdGerencia");

            migrationBuilder.CreateIndex(
                name: "IX_GerenciaUsuario_IdTipoUsuarioGerencia",
                table: "GerenciaUsuario",
                column: "IdTipoUsuarioGerencia");

            migrationBuilder.CreateIndex(
                name: "IX_GerenciaUsuario_IdUsuarioCadastro",
                table: "GerenciaUsuario",
                column: "IdUsuarioCadastro");

            migrationBuilder.CreateIndex(
                name: "IX_GerenciaUsuario_IdUsuarioGerencia",
                table: "GerenciaUsuario",
                column: "IdUsuarioGerencia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GerenciaUsuario");

            migrationBuilder.DropTable(
                name: "TipoUsuarioGerencia");
        }
    }
}
