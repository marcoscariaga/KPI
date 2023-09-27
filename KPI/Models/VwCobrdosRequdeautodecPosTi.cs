using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
public partial class VwCobrdosRequdeautodecPosTi
{
    [Column("NR_GUIA")]
    public int NrGuia { get; set; }

    [Column("ID_REQUERIMENTO")]
    public int? IdRequerimento { get; set; }

    [Column("CD_RECEITA")]
    public int CdReceita { get; set; }

    [Column("DatadeVencimento_1", TypeName = "datetime")]
    public DateTime? DatadeVencimento1 { get; set; }

    [Column("DatadeVencimento_2", TypeName = "datetime")]
    public DateTime? DatadeVencimento2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DatadaCompetencia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DatadoPagamento { get; set; }

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

    [Column("TP_IMPOSTO")]
    public int? TpImposto { get; set; }

    [Column("TP_MEI")]
    public bool? TpMei { get; set; }

    [Column("SITUACAO")]
    public int? Situacao { get; set; }
}
