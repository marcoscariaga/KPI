using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SigProc.infra.dados.Migrations
{
    /// <inheritdoc />
    public partial class processoTramitaçãoetapaProcesso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdEtapaProcesso",
                table: "ProcessoTramitacao",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProcessoTramitacao_IdEtapaProcesso",
                table: "ProcessoTramitacao",
                column: "IdEtapaProcesso");

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessoTramitacao_EtapaProcesso_IdEtapaProcesso",
                table: "ProcessoTramitacao",
                column: "IdEtapaProcesso",
                principalTable: "EtapaProcesso",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProcessoTramitacao_EtapaProcesso_IdEtapaProcesso",
                table: "ProcessoTramitacao");

            migrationBuilder.DropIndex(
                name: "IX_ProcessoTramitacao_IdEtapaProcesso",
                table: "ProcessoTramitacao");

            migrationBuilder.DropColumn(
                name: "IdEtapaProcesso",
                table: "ProcessoTramitacao");
        }
    }
}
