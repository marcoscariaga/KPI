using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("PerguntasDoModelo")]
[Index("ModeloRoteiroId", Name = "IX_PerguntasDoModelo_ModeloRoteiro_id")]
[Index("PerguntaId", Name = "IX_PerguntasDoModelo_Pergunta_id")]
public partial class PerguntasDoModelo
{
    /// <summary>
    /// Modelo do roteiro
    /// </summary>
    [Column("ModeloRoteiro_id")]
    public int ModeloRoteiroId { get; set; }

    /// <summary>
    /// Código da pergunta
    /// </summary>
    [Column("Pergunta_id")]
    public int PerguntaId { get; set; }

    [ForeignKey("ModeloRoteiroId")]
    public virtual ModeloRoteiro ModeloRoteiro { get; set; } = null!;

    [ForeignKey("PerguntaId")]
    public virtual Perguntum Pergunta { get; set; } = null!;
}
