using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("RespostasDoRequerimento")]
[Index("PerguntaId", Name = "IX_RespostasDoRequerimento_PerguntaId")]
[Index("RequerimentoId", Name = "IX_RespostasDoRequerimento_RequerimentoId")]
[Index("RequerimentoId", "PerguntaId", Name = "UQ__Resposta__227C51613BA0BFE9", IsUnique = true)]
public partial class RespostasDoRequerimento
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
    /// Assunto
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? Assunto { get; set; }

    /// <summary>
    /// Enunciado
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? Enunciado { get; set; }

    /// <summary>
    /// Valor
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? Valor { get; set; }

    /// <summary>
    /// Valor do arquivo
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? ValorArquivo { get; set; }

    /// <summary>
    /// 1-Aceitar  2-Rejeitar  3-Exigência
    /// </summary>
    public int TipoParecerId { get; set; }

    /// <summary>
    /// 1-Comum  2-Alimento  3-Engenharia  4-Saúde  5-Zoonose
    /// </summary>
    public int SegmentoId { get; set; }

    /// <summary>
    /// Código da pergunta
    /// </summary>
    public int PerguntaId { get; set; }

    [ForeignKey("PerguntaId")]
    public virtual Perguntum Pergunta { get; set; } = null!;

    [ForeignKey("RequerimentoId")]
    public virtual RequerimentoAutodeclaracao Requerimento { get; set; } = null!;
}
