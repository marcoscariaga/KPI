using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SigProc.infra.dados.Migrations
{
    /// <inheritdoc />
    public partial class SigProc20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProcessoTramitacao_Despacho_IdDespacho",
                table: "ProcessoTramitacao");

            migrationBuilder.DropIndex(
                name: "IX_ProcessoTramitacao_IdDespacho",
                table: "ProcessoTramitacao");

            migrationBuilder.DropColumn(
                name: "DataDigitacao",
                table: "ProcessoTramitacao");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "ProcessoTramitacao");

            migrationBuilder.DropColumn(
                name: "IdDespacho",
                table: "ProcessoTramitacao");

            migrationBuilder.DropColumn(
                name: "MatriculaDespacho",
                table: "ProcessoTramitacao");

            migrationBuilder.AddColumn<string>(
                name: "Despacho",
                table: "ProcessoTramitacao",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Despacho",
                table: "ProcessoTramitacao");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataDigitacao",
                table: "ProcessoTramitacao",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "ProcessoTramitacao",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdDespacho",
                table: "ProcessoTramitacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MatriculaDespacho",
                table: "ProcessoTramitacao",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProcessoTramitacao_IdDespacho",
                table: "ProcessoTramitacao",
                column: "IdDespacho");

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessoTramitacao_Despacho_IdDespacho",
                table: "ProcessoTramitacao",
                column: "IdDespacho",
                principalTable: "Despacho",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
