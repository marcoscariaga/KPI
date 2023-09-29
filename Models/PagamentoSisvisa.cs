using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[PrimaryKey("AaExercicio", "CdBanco", "NrBda", "NrComplemento", "NrLoteNsa", "TpLoteD", "SqDoc")]
[Table("pagamentoSisvisa")]
[Index("CdReceita", "NrGuia", Name = "gqs_solutisNaoAtendeuEmail-09052019")]
public partial class PagamentoSisvisa
{
    [Key]
    [Column("AA_EXERCICIO")]
    public int AaExercicio { get; set; }

    [Key]
    [Column("CD_BANCO")]
    public int CdBanco { get; set; }

    [Key]
    [Column("NR_BDA")]
    public int NrBda { get; set; }

    [Key]
    [Column("NR_COMPLEMENTO")]
    public int NrComplemento { get; set; }

    [Key]
    [Column("NR_LOTE_NSA")]
    public int NrLoteNsa { get; set; }

    [Key]
    [Column("TP_LOTE_D")]
    public int TpLoteD { get; set; }

    [Key]
    [Column("SQ_DOC")]
    public int SqDoc { get; set; }

    [Column("CD_RECEITA")]
    public int? CdReceita { get; set; }

    [Column("CD_USU_ALT")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CdUsuAlt { get; set; }

    [Column("CD_USU_INCL")]
    [StringLength(10)]
    [Unicode(false)]
    public string CdUsuIncl { get; set; } = null!;

    [Column("DT_ALT", TypeName = "datetime")]
    public DateTime? DtAlt { get; set; }

    [Column("DT_INCL", TypeName = "datetime")]
    public DateTime DtIncl { get; set; }

    [Column("DT_VENCTO", TypeName = "datetime")]
    public DateTime? DtVencto { get; set; }

    [Column("DT_PAGTO", TypeName = "datetime")]
    public DateTime? DtPagto { get; set; }

    [Column("NR_INSCRICAO")]
    public int? NrInscricao { get; set; }

    [Column("NR_GUIA")]
    public int? NrGuia { get; set; }

    [Column("NR_COMPETENCIA")]
    public int? NrCompetencia { get; set; }

    [Column("NR_CODIGO_BARRAS")]
    [StringLength(48)]
    [Unicode(false)]
    public string? NrCodigoBarras { get; set; }

    [Column("NR_LOTE_IPTU")]
    public int? NrLoteIptu { get; set; }

    [Column("ST_DOC_D")]
    [StringLength(2)]
    [Unicode(false)]
    public string? StDocD { get; set; }

    [Column("TP_IMPOSTO")]
    public int? TpImposto { get; set; }

    [Column("VL_PAGO", TypeName = "money")]
    public decimal VlPago { get; set; }

    [Column("VL_RECEITA", TypeName = "money")]
    public decimal VlReceita { get; set; }

    [Column("VL_PRINCIPAL", TypeName = "money")]
    public decimal VlPrincipal { get; set; }

    [Column("VL_MORA", TypeName = "money")]
    public decimal VlMora { get; set; }

    [Column("VL_MULTA", TypeName = "money")]
    public decimal VlMulta { get; set; }

    [Column("VL_MULTAF_TCDL", TypeName = "money")]
    public decimal VlMultafTcdl { get; set; }

    [Column("VL_MULTAP_TSD", TypeName = "money")]
    public decimal VlMultapTsd { get; set; }

    [Column("VL_INSU_TIP", TypeName = "money")]
    public decimal VlInsuTip { get; set; }

    [Column("VL_JUROS", TypeName = "money")]
    public decimal VlJuros { get; set; }
}
