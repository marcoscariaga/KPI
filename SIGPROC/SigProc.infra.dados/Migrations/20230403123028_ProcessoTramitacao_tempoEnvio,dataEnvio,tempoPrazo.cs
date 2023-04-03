using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SigProc.infra.dados.Migrations
{
    /// <inheritdoc />
    public partial class ProcessoTramitacaotempoEnviodataEnviotempoPrazo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataEnvio",
                table: "ProcessoTramitacao",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TempoEnvio",
                table: "ProcessoTramitacao",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TempoPrazo",
                table: "ProcessoTramitacao",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataEnvio",
                table: "ProcessoTramitacao");

            migrationBuilder.DropColumn(
                name: "TempoEnvio",
                table: "ProcessoTramitacao");

            migrationBuilder.DropColumn(
                name: "TempoPrazo",
                table: "ProcessoTramitacao");
        }
    }
}
