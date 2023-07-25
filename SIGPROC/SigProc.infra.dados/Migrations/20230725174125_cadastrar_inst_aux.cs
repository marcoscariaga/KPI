using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SigProc.infra.dados.Migrations
{
    /// <inheritdoc />
    public partial class cadastrarinstaux : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processo_StatusProcesso_IdStatusProcesso",
                table: "Processo");

            migrationBuilder.AlterColumn<int>(
                name: "IdStatusProcesso",
                table: "Processo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdInstrumentosAuxiliares",
                table: "Processo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdParaContratacao",
                table: "Processo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InstrumentosAuxiliares",
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
                    table.PrimaryKey("PK_InstrumentosAuxiliares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParaContratacao",
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
                    table.PrimaryKey("PK_ParaContratacao", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Processo_IdInstrumentosAuxiliares",
                table: "Processo",
                column: "IdInstrumentosAuxiliares");

            migrationBuilder.CreateIndex(
                name: "IX_Processo_IdParaContratacao",
                table: "Processo",
                column: "IdParaContratacao");

            migrationBuilder.AddForeignKey(
                name: "FK_Processo_InstrumentosAuxiliares_IdInstrumentosAuxiliares",
                table: "Processo",
                column: "IdInstrumentosAuxiliares",
                principalTable: "InstrumentosAuxiliares",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Processo_ParaContratacao_IdParaContratacao",
                table: "Processo",
                column: "IdParaContratacao",
                principalTable: "ParaContratacao",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Processo_StatusProcesso_IdStatusProcesso",
                table: "Processo",
                column: "IdStatusProcesso",
                principalTable: "StatusProcesso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processo_InstrumentosAuxiliares_IdInstrumentosAuxiliares",
                table: "Processo");

            migrationBuilder.DropForeignKey(
                name: "FK_Processo_ParaContratacao_IdParaContratacao",
                table: "Processo");

            migrationBuilder.DropForeignKey(
                name: "FK_Processo_StatusProcesso_IdStatusProcesso",
                table: "Processo");

            migrationBuilder.DropTable(
                name: "InstrumentosAuxiliares");

            migrationBuilder.DropTable(
                name: "ParaContratacao");

            migrationBuilder.DropIndex(
                name: "IX_Processo_IdInstrumentosAuxiliares",
                table: "Processo");

            migrationBuilder.DropIndex(
                name: "IX_Processo_IdParaContratacao",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "IdInstrumentosAuxiliares",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "IdParaContratacao",
                table: "Processo");

            migrationBuilder.AlterColumn<int>(
                name: "IdStatusProcesso",
                table: "Processo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Processo_StatusProcesso_IdStatusProcesso",
                table: "Processo",
                column: "IdStatusProcesso",
                principalTable: "StatusProcesso",
                principalColumn: "Id");
        }
    }
}
