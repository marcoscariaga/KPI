using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SigProc.infra.dados.Migrations
{
    /// <inheritdoc />
    public partial class processoTramitacaoAjustes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessoTramitacao_Usuario_IdUsuarioTramitacao",
                table: "ProcessoTramitacao",
                column: "IdUsuarioTramitacao",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.AddForeignKey(
                name: "FK_ProcessoTramitacao_Usuario_IdUsuarioTramitacao",
                table: "ProcessoTramitacao",
                column: "IdUsuarioTramitacao",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
