using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("PerguntasDoAssunto")]
[Index("AssuntoId", Name = "IX_PerguntasDoAssunto_AssuntoId")]
[Index("PerguntaId", Name = "IX_PerguntasDoAssunto_PerguntaId")]
public partial class PerguntasDoAssunto
{
    /// <summary>
    /// Código do assunto
    /// </summary>
    public int AssuntoId { get; set; }

    /// <summary>
    /// Ordem
    /// </summary>
    public int Ordem { get; set; }

    /// <summary>
    /// Código da pergunta
    /// </summary>
    public int PerguntaId { get; set; }

    [ForeignKey("AssuntoId")]
    public virtual Assunto Assunto { get; set; } = null!;

    [ForeignKey("PerguntaId")]
    public virtual Perguntum Pergunta { get; set; } = null!;
}
