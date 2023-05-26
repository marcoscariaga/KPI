using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SigProc.infra.dados.Migrations
{
    /// <inheritdoc />
    public partial class ProcessoStatusProcesso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdStatusProcesso",
                table: "Processo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Processo_IdStatusProcesso",
                table: "Processo",
                column: "IdStatusProcesso");

            migrationBuilder.AddForeignKey(
                name: "FK_Processo_StatusProcesso_IdStatusProcesso",
                table: "Processo",
                column: "IdStatusProcesso",
                principalTable: "StatusProcesso",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processo_StatusProcesso_IdStatusProcesso",
                table: "Processo");

            migrationBuilder.DropIndex(
                name: "IX_Processo_IdStatusProcesso",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "IdStatusProcesso",
                table: "Processo");
        }
    }
}
