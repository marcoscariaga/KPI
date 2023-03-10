using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SigProc.infra.dados.Migrations
{
    /// <inheritdoc />
    public partial class DadosDeTramitacaoDoProcessoSicop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DadosDeTramitacaoSicop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rotina = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroDoProcesso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opcao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Item01 = table.Column<string>(name: "Item_01", type: "nvarchar(max)", nullable: false),
                    MatDig01 = table.Column<string>(name: "MatDig_01", type: "nvarchar(max)", nullable: false),
                    MatRec01 = table.Column<string>(name: "MatRec_01", type: "nvarchar(max)", nullable: false),
                    OrgaoDeDestino01 = table.Column<string>(name: "OrgaoDeDestino_01", type: "nvarchar(max)", nullable: false),
                    DataDoDespacho01 = table.Column<string>(name: "DataDoDespacho_01", type: "nvarchar(max)", nullable: false),
                    Sequencia01 = table.Column<string>(name: "Sequencia_01", type: "nvarchar(max)", nullable: false),
                    Guia01 = table.Column<string>(name: "Guia_01", type: "nvarchar(max)", nullable: false),
                    Despacho01 = table.Column<string>(name: "Despacho_01", type: "nvarchar(max)", nullable: false),
                    Item02 = table.Column<string>(name: "Item_02", type: "nvarchar(max)", nullable: false),
                    MatDig02 = table.Column<string>(name: "MatDig_02", type: "nvarchar(max)", nullable: false),
                    MatRec02 = table.Column<string>(name: "MatRec_02", type: "nvarchar(max)", nullable: false),
                    OrgaoDeDestino02 = table.Column<string>(name: "OrgaoDeDestino_02", type: "nvarchar(max)", nullable: false),
                    DataDoDespacho02 = table.Column<string>(name: "DataDoDespacho_02", type: "nvarchar(max)", nullable: false),
                    Sequencia02 = table.Column<string>(name: "Sequencia_02", type: "nvarchar(max)", nullable: false),
                    Guia02 = table.Column<string>(name: "Guia_02", type: "nvarchar(max)", nullable: false),
                    Despacho02 = table.Column<string>(name: "Despacho_02", type: "nvarchar(max)", nullable: false),
                    Item03 = table.Column<string>(name: "Item_03", type: "nvarchar(max)", nullable: false),
                    MatDig03 = table.Column<string>(name: "MatDig_03", type: "nvarchar(max)", nullable: false),
                    MatRec03 = table.Column<string>(name: "MatRec_03", type: "nvarchar(max)", nullable: false),
                    OrgaoDeDestino03 = table.Column<string>(name: "OrgaoDeDestino_03", type: "nvarchar(max)", nullable: false),
                    DataDoDespacho03 = table.Column<string>(name: "DataDoDespacho_03", type: "nvarchar(max)", nullable: false),
                    Sequencia03 = table.Column<string>(name: "Sequencia_03", type: "nvarchar(max)", nullable: false),
                    Guia03 = table.Column<string>(name: "Guia_03", type: "nvarchar(max)", nullable: false),
                    Despacho03 = table.Column<string>(name: "Despacho_03", type: "nvarchar(max)", nullable: false),
                    Item04 = table.Column<string>(name: "Item_04", type: "nvarchar(max)", nullable: false),
                    MatDig04 = table.Column<string>(name: "MatDig_04", type: "nvarchar(max)", nullable: false),
                    MatRec04 = table.Column<string>(name: "MatRec_04", type: "nvarchar(max)", nullable: false),
                    OrgaoDeDestino04 = table.Column<string>(name: "OrgaoDeDestino_04", type: "nvarchar(max)", nullable: false),
                    DataDoDespacho04 = table.Column<string>(name: "DataDoDespacho_04", type: "nvarchar(max)", nullable: false),
                    Sequencia04 = table.Column<string>(name: "Sequencia_04", type: "nvarchar(max)", nullable: false),
                    Guia04 = table.Column<string>(name: "Guia_04", type: "nvarchar(max)", nullable: false),
                    Despacho04 = table.Column<string>(name: "Despacho_04", type: "nvarchar(max)", nullable: false),
                    Item05 = table.Column<string>(name: "Item_05", type: "nvarchar(max)", nullable: false),
                    MatDig05 = table.Column<string>(name: "MatDig_05", type: "nvarchar(max)", nullable: false),
                    MatRec05 = table.Column<string>(name: "MatRec_05", type: "nvarchar(max)", nullable: false),
                    OrgaoDeDestino05 = table.Column<string>(name: "OrgaoDeDestino_05", type: "nvarchar(max)", nullable: false),
                    DataDoDespacho05 = table.Column<string>(name: "DataDoDespacho_05", type: "nvarchar(max)", nullable: false),
                    Sequencia05 = table.Column<string>(name: "Sequencia_05", type: "nvarchar(max)", nullable: false),
                    Guia05 = table.Column<string>(name: "Guia_05", type: "nvarchar(max)", nullable: false),
                    Despacho05 = table.Column<string>(name: "Despacho_05", type: "nvarchar(max)", nullable: false),
                    Item06 = table.Column<string>(name: "Item_06", type: "nvarchar(max)", nullable: false),
                    MatDig06 = table.Column<string>(name: "MatDig_06", type: "nvarchar(max)", nullable: false),
                    MatRec06 = table.Column<string>(name: "MatRec_06", type: "nvarchar(max)", nullable: false),
                    OrgaoDeDestino06 = table.Column<string>(name: "OrgaoDeDestino_06", type: "nvarchar(max)", nullable: false),
                    DataDoDespacho06 = table.Column<string>(name: "DataDoDespacho_06", type: "nvarchar(max)", nullable: false),
                    Sequencia06 = table.Column<string>(name: "Sequencia_06", type: "nvarchar(max)", nullable: false),
                    Guia06 = table.Column<string>(name: "Guia_06", type: "nvarchar(max)", nullable: false),
                    Despacho06 = table.Column<string>(name: "Despacho_06", type: "nvarchar(max)", nullable: false),
                    Item07 = table.Column<string>(name: "Item_07", type: "nvarchar(max)", nullable: false),
                    MatDig07 = table.Column<string>(name: "MatDig_07", type: "nvarchar(max)", nullable: false),
                    MatRec07 = table.Column<string>(name: "MatRec_07", type: "nvarchar(max)", nullable: false),
                    OrgaoDeDestino07 = table.Column<string>(name: "OrgaoDeDestino_07", type: "nvarchar(max)", nullable: false),
                    DataDoDespacho07 = table.Column<string>(name: "DataDoDespacho_07", type: "nvarchar(max)", nullable: false),
                    Sequencia07 = table.Column<string>(name: "Sequencia_07", type: "nvarchar(max)", nullable: false),
                    Guia07 = table.Column<string>(name: "Guia_07", type: "nvarchar(max)", nullable: false),
                    Despacho07 = table.Column<string>(name: "Despacho_07", type: "nvarchar(max)", nullable: false),
                    Item08 = table.Column<string>(name: "Item_08", type: "nvarchar(max)", nullable: false),
                    MatDig08 = table.Column<string>(name: "MatDig_08", type: "nvarchar(max)", nullable: false),
                    MatRec08 = table.Column<string>(name: "MatRec_08", type: "nvarchar(max)", nullable: false),
                    OrgaoDeDestino08 = table.Column<string>(name: "OrgaoDeDestino_08", type: "nvarchar(max)", nullable: false),
                    DataDoDespacho08 = table.Column<string>(name: "DataDoDespacho_08", type: "nvarchar(max)", nullable: false),
                    Sequencia08 = table.Column<string>(name: "Sequencia_08", type: "nvarchar(max)", nullable: false),
                    Guia08 = table.Column<string>(name: "Guia_08", type: "nvarchar(max)", nullable: false),
                    Despacho08 = table.Column<string>(name: "Despacho_08", type: "nvarchar(max)", nullable: false),
                    Item09 = table.Column<string>(name: "Item_09", type: "nvarchar(max)", nullable: false),
                    MatDig09 = table.Column<string>(name: "MatDig_09", type: "nvarchar(max)", nullable: false),
                    MatRec09 = table.Column<string>(name: "MatRec_09", type: "nvarchar(max)", nullable: false),
                    OrgaoDeDestino09 = table.Column<string>(name: "OrgaoDeDestino_09", type: "nvarchar(max)", nullable: false),
                    DataDoDespacho09 = table.Column<string>(name: "DataDoDespacho_09", type: "nvarchar(max)", nullable: false),
                    Sequencia09 = table.Column<string>(name: "Sequencia_09", type: "nvarchar(max)", nullable: false),
                    Guia09 = table.Column<string>(name: "Guia_09", type: "nvarchar(max)", nullable: false),
                    Despacho09 = table.Column<string>(name: "Despacho_09", type: "nvarchar(max)", nullable: false),
                    Item10 = table.Column<string>(name: "Item_10", type: "nvarchar(max)", nullable: false),
                    MatDig10 = table.Column<string>(name: "MatDig_10", type: "nvarchar(max)", nullable: false),
                    MatRec10 = table.Column<string>(name: "MatRec_10", type: "nvarchar(max)", nullable: false),
                    OrgaoDeDestino10 = table.Column<string>(name: "OrgaoDeDestino_10", type: "nvarchar(max)", nullable: false),
                    DataDoDespacho10 = table.Column<string>(name: "DataDoDespacho_10", type: "nvarchar(max)", nullable: false),
                    Sequencia10 = table.Column<string>(name: "Sequencia_10", type: "nvarchar(max)", nullable: false),
                    Guia10 = table.Column<string>(name: "Guia_10", type: "nvarchar(max)", nullable: false),
                    Despacho10 = table.Column<string>(name: "Despacho_10", type: "nvarchar(max)", nullable: false),
                    Item11 = table.Column<string>(name: "Item_11", type: "nvarchar(max)", nullable: false),
                    MatDig11 = table.Column<string>(name: "MatDig_11", type: "nvarchar(max)", nullable: false),
                    MatRec11 = table.Column<string>(name: "MatRec_11", type: "nvarchar(max)", nullable: false),
                    OrgaoDeDestino11 = table.Column<string>(name: "OrgaoDeDestino_11", type: "nvarchar(max)", nullable: false),
                    DataDoDespacho11 = table.Column<string>(name: "DataDoDespacho_11", type: "nvarchar(max)", nullable: false),
                    Sequencia11 = table.Column<string>(name: "Sequencia_11", type: "nvarchar(max)", nullable: false),
                    Guia11 = table.Column<string>(name: "Guia_11", type: "nvarchar(max)", nullable: false),
                    Despacho11 = table.Column<string>(name: "Despacho_11", type: "nvarchar(max)", nullable: false),
                    Item12 = table.Column<string>(name: "Item_12", type: "nvarchar(max)", nullable: false),
                    MatDig12 = table.Column<string>(name: "MatDig_12", type: "nvarchar(max)", nullable: false),
                    MatRec12 = table.Column<string>(name: "MatRec_12", type: "nvarchar(max)", nullable: false),
                    OrgaoDeDestino12 = table.Column<string>(name: "OrgaoDeDestino_12", type: "nvarchar(max)", nullable: false),
                    DataDoDespacho12 = table.Column<string>(name: "DataDoDespacho_12", type: "nvarchar(max)", nullable: false),
                    Sequencia12 = table.Column<string>(name: "Sequencia_12", type: "nvarchar(max)", nullable: false),
                    Guia12 = table.Column<string>(name: "Guia_12", type: "nvarchar(max)", nullable: false),
                    Despacho12 = table.Column<string>(name: "Despacho_12", type: "nvarchar(max)", nullable: false),
                    Item13 = table.Column<string>(name: "Item_13", type: "nvarchar(max)", nullable: false),
                    MatDig13 = table.Column<string>(name: "MatDig_13", type: "nvarchar(max)", nullable: false),
                    MatRec13 = table.Column<string>(name: "MatRec_13", type: "nvarchar(max)", nullable: false),
                    OrgaoDeDestino13 = table.Column<string>(name: "OrgaoDeDestino_13", type: "nvarchar(max)", nullable: false),
                    DataDoDespacho13 = table.Column<string>(name: "DataDoDespacho_13", type: "nvarchar(max)", nullable: false),
                    Sequencia13 = table.Column<string>(name: "Sequencia_13", type: "nvarchar(max)", nullable: false),
                    Guia13 = table.Column<string>(name: "Guia_13", type: "nvarchar(max)", nullable: false),
                    Despacho13 = table.Column<string>(name: "Despacho_13", type: "nvarchar(max)", nullable: false),
                    Item14 = table.Column<string>(name: "Item_14", type: "nvarchar(max)", nullable: false),
                    MatDig14 = table.Column<string>(name: "MatDig_14", type: "nvarchar(max)", nullable: false),
                    MatRec14 = table.Column<string>(name: "MatRec_14", type: "nvarchar(max)", nullable: false),
                    OrgaoDeDestino14 = table.Column<string>(name: "OrgaoDeDestino_14", type: "nvarchar(max)", nullable: false),
                    DataDoDespacho14 = table.Column<string>(name: "DataDoDespacho_14", type: "nvarchar(max)", nullable: false),
                    Sequencia14 = table.Column<string>(name: "Sequencia_14", type: "nvarchar(max)", nullable: false),
                    Guia14 = table.Column<string>(name: "Guia_14", type: "nvarchar(max)", nullable: false),
                    Despacho14 = table.Column<string>(name: "Despacho_14", type: "nvarchar(max)", nullable: false),
                    Concad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusLine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEdicao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadosDeTramitacaoSicop", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DadosDeTramitacaoSicop");
        }
    }
}
