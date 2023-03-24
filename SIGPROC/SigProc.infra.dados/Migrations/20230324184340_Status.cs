using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SigProc.infra.dados.Migrations
{
    /// <inheritdoc />
    public partial class Status : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GerenciaPrazo_TipoContratacao_IdTipoContratacao",
                table: "GerenciaPrazo");

            migrationBuilder.DropForeignKey(
                name: "FK_GerenciaPrazo_TipoProcesso_IdTipoProcesso",
                table: "GerenciaPrazo");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Usuario",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "IdTipoProcesso",
                table: "GerenciaPrazo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdTipoContratacao",
                table: "GerenciaPrazo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "DadosDoProcessoSicop",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "DadosDeTramitacaoSicop",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_GerenciaPrazo_TipoContratacao_IdTipoContratacao",
                table: "GerenciaPrazo",
                column: "IdTipoContratacao",
                principalTable: "TipoContratacao",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GerenciaPrazo_TipoProcesso_IdTipoProcesso",
                table: "GerenciaPrazo",
                column: "IdTipoProcesso",
                principalTable: "TipoProcesso",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GerenciaPrazo_TipoContratacao_IdTipoContratacao",
                table: "GerenciaPrazo");

            migrationBuilder.DropForeignKey(
                name: "FK_GerenciaPrazo_TipoProcesso_IdTipoProcesso",
                table: "GerenciaPrazo");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "DadosDoProcessoSicop");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "DadosDeTramitacaoSicop");

            migrationBuilder.AlterColumn<int>(
                name: "IdTipoProcesso",
                table: "GerenciaPrazo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdTipoContratacao",
                table: "GerenciaPrazo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GerenciaPrazo_TipoContratacao_IdTipoContratacao",
                table: "GerenciaPrazo",
                column: "IdTipoContratacao",
                principalTable: "TipoContratacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GerenciaPrazo_TipoProcesso_IdTipoProcesso",
                table: "GerenciaPrazo",
                column: "IdTipoProcesso",
                principalTable: "TipoProcesso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
