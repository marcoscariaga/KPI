using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("CobrancaSisvisa")]
[Index("IdRequerimento", Name = "gqs_idRequerimento")]
public partial class CobrancaSisvisa
{
    [Key]
    [Column("NR_GUIA")]
    public int NrGuia { get; set; }

    [Column("CD_RECEITA")]
    public int CdReceita { get; set; }

    [Column("DT_VENCTO_1", TypeName = "datetime")]
    public DateTime DtVencto1 { get; set; }

    [Column("DT_VENCTO_2", TypeName = "datetime")]
    public DateTime? DtVencto2 { get; set; }

    [Column("DT_COMPETENCIA", TypeName = "datetime")]
    public DateTime DtCompetencia { get; set; }

    [Column("DT_PAGAMENTO", TypeName = "datetime")]
    public DateTime? DtPagamento { get; set; }

    [Column("VL_PRINCIPAL", TypeName = "money")]
    public decimal VlPrincipal { get; set; }

    [Column("VL_PRINCIPALDESC", TypeName = "money")]
    public decimal? VlPrincipaldesc { get; set; }

    [Column("VL_MORA", TypeName = "money")]
    public decimal? VlMora { get; set; }

    [Column("VL_MULTA", TypeName = "money")]
    public decimal? VlMulta { get; set; }

    [Column("VL_RECEITA", TypeName = "money")]
    public decimal VlReceita { get; set; }

    [Column("NR_CPF")]
    [StringLength(20)]
    public string? NrCpf { get; set; }

    [Column("NR_CODIGO_BARRA")]
    [StringLength(48)]
    public string NrCodigoBarra { get; set; } = null!;

    [Column("NM_TIPO_LICENCIAMENTO")]
    [StringLength(100)]
    public string? NmTipoLicenciamento { get; set; }

    [Column("TX_INFO_COMPLEMENTAR")]
    [StringLength(200)]
    public string? TxInfoComplementar { get; set; }

    [Column("TP_IMPOSTO")]
    public int? TpImposto { get; set; }

    [Column("TP_MEI")]
    public bool? TpMei { get; set; }

    [Column("SITUACAO")]
    public int? Situacao { get; set; }

    [Column("ID_REQUERIMENTO")]
    public int? IdRequerimento { get; set; }

    [Column("CD_LINHA_DIGITAVEL")]
    [StringLength(100)]
    public string? CdLinhaDigitavel { get; set; }

    [Column("TX_GUIA")]
    [StringLength(600)]
    [Unicode(false)]
    public string? TxGuia { get; set; }

    [Column("CD_TIPO_REQUERIMENTO")]
    public int? CdTipoRequerimento { get; set; }

    [Column("DT_AVISO_EXPIRACAO", TypeName = "datetime")]
    public DateTime? DtAvisoExpiracao { get; set; }
}
