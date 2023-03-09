using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SigProc.infra.dados.Migrations
{
    /// <inheritdoc />
    public partial class DadosDoProcessoSicop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_Responsavel",
                table: "Gerencia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Prazo",
                table: "Gerencia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Gerencia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DadosDoProcessoSicop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rotina = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroDoProcesso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentacaoDoIdentificador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformacaoVolume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformacaoTela = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PastaDeAssentamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeDoRequerente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgaoDeOrigem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoDoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescricaoDoTipoDoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroDoTipoDoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgaoDoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformacaoTela1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformacaoTela2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformacaoTela3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformacaoTela4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformacaoTela5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutoDeInfracao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformacaoTela6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformacaoTela7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformacaoTela8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoAssunto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformacaoComplementar1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformacaoComplementar2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformacaoComplementar3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDoProcesso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDeCadastroDeProcesso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoraDeCadastroDoProcesso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatriculaRecebedorCadastro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatriculaDigitadorProcesso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcessoPrincipal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentificacaoProcesso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NovoPosicionamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformacaoTela9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformacaoTela10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatriculaDigitadorTramitacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDigitacaoTramitacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDeRecebimentoTramitacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformacaoTela11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformacaoTela12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDeDespachoTramitacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatriculaDoDespachoTramitacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatriculaDoRecebedorTramitacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroGuiaTramitacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SequenciaTramitacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgaoOrigemTramitacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgaoDestinoTramitacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnderecoDestinoProcessoTramitacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DespachoProcessoTramitacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusLine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEdicao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadosDoProcessoSicop", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gerencia_UsuarioId",
                table: "Gerencia",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gerencia_Usuario_UsuarioId",
                table: "Gerencia",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gerencia_Usuario_UsuarioId",
                table: "Gerencia");

            migrationBuilder.DropTable(
                name: "DadosDoProcessoSicop");

            migrationBuilder.DropIndex(
                name: "IX_Gerencia_UsuarioId",
                table: "Gerencia");

            migrationBuilder.DropColumn(
                name: "Id_Responsavel",
                table: "Gerencia");

            migrationBuilder.DropColumn(
                name: "Prazo",
                table: "Gerencia");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Gerencia");
        }
    }
}
