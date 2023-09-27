using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("SegmentosDoRequerimento")]
[Index("RequerimentoId", Name = "IX_SegmentosDoRequerimento_COLUNA")]
[Index("SegmentoId", Name = "gqs_segmento")]
[Index("SegmentoId", Name = "gqs_segmentoID")]
public partial class SegmentosDoRequerimento
{
    /// <summary>
    /// Código do requerimento
    /// </summary>
    public int RequerimentoId { get; set; }

    /// <summary>
    /// 1-Comum  2-Alimento  3-Engenharia  4-Saúde  5-Zoonose
    /// </summary>
    public int SegmentoId { get; set; }

    /// <summary>
    /// Data de início da análise
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? DataInicioAnalise { get; set; }

    /// <summary>
    /// Data de fim da análise
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? DataFimAnalise { get; set; }

    /// <summary>
    /// Data de início da exigência
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? DataInicioExigencia { get; set; }

    /// <summary>
    /// Data de fim da exigência
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? DataFimExigencia { get; set; }

    /// <summary>
    /// Data de início do deferimento
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? DataInicioDeferimento { get; set; }

    /// <summary>
    /// Data de fim do deferimento
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? DataFimDeferimento { get; set; }

    public bool Aprovado { get; set; }

    [ForeignKey("RequerimentoId")]
    public virtual RequerimentoAutodeclaracao Requerimento { get; set; } = null!;
}
