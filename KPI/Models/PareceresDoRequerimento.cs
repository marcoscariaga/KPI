using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("PareceresDoRequerimento")]
[Index("PerguntaId", Name = "IX_PareceresDoRequerimento_PerguntaId")]
[Index("RequerimentoId", Name = "IX_PareceresDoRequerimento_RequerimentoId")]
public partial class PareceresDoRequerimento
{
    /// <summary>
    /// Código do requerimento
    /// </summary>
    public int RequerimentoId { get; set; }

    /// <summary>
    /// Ordem
    /// </summary>
    public int Ordem { get; set; }

    /// <summary>
    /// Matrícula
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string Matricula { get; set; } = null!;

    /// <summary>
    /// Observação
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? Observacao { get; set; }

    /// <summary>
    /// Data
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime Data { get; set; }

    /// <summary>
    /// 1-Aceitar  2-Rejeitar  3-Exigência
    /// </summary>
    public int TipoParecerId { get; set; }

    /// <summary>
    /// Código da pergunta
    /// </summary>
    public int PerguntaId { get; set; }

    [ForeignKey("PerguntaId")]
    public virtual Perguntum Pergunta { get; set; } = null!;

    [ForeignKey("RequerimentoId")]
    public virtual RequerimentoAutodeclaracao Requerimento { get; set; } = null!;
}
