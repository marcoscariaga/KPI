using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("PerguntasDoRoteiro")]
[Index("PerguntaId", Name = "IX_PerguntasDoRoteiro_Pergunta_id")]
[Index("RoteiroId", Name = "IX_PerguntasDoRoteiro_Roteiro_id")]
public partial class PerguntasDoRoteiro
{
    /// <summary>
    /// Código do roteiro
    /// </summary>
    [Column("Roteiro_id")]
    public int RoteiroId { get; set; }

    /// <summary>
    /// Código da pergunta
    /// </summary>
    [Column("Pergunta_id")]
    public int PerguntaId { get; set; }

    [ForeignKey("PerguntaId")]
    public virtual Perguntum Pergunta { get; set; } = null!;

    [ForeignKey("RoteiroId")]
    public virtual Roteiro Roteiro { get; set; } = null!;
}
