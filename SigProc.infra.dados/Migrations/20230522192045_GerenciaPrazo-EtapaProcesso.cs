using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SigProc.infra.dados.Migrations
{
    /// <inheritdoc />
    public partial class GerenciaPrazoEtapaProcesso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdEtapaProcesso",
                table: "GerenciaPrazo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EtapaProcesso",
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
                    table.PrimaryKey("PK_EtapaProcesso", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GerenciaPrazo_IdEtapaProcesso",
                table: "GerenciaPrazo",
                column: "IdEtapaProcesso");

            migrationBuilder.AddForeignKey(
                name: "FK_GerenciaPrazo_EtapaProcesso_IdEtapaProcesso",
                table: "GerenciaPrazo",
                column: "IdEtapaProcesso",
                principalTable: "EtapaProcesso",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GerenciaPrazo_EtapaProcesso_IdEtapaProcesso",
                table: "GerenciaPrazo");

            migrationBuilder.DropTable(
                name: "EtapaProcesso");

            migrationBuilder.DropIndex(
                name: "IX_GerenciaPrazo_IdEtapaProcesso",
                table: "GerenciaPrazo");

            migrationBuilder.DropColumn(
                name: "IdEtapaProcesso",
                table: "GerenciaPrazo");
        }
    }
}
