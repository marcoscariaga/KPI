using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("AssuntosDoRoteiro")]
[Index("AssuntoId", Name = "IX_AssuntosDoRoteiro_AssuntoId")]
[Index("RoteiroId", Name = "IX_AssuntosDoRoteiro_RoteiroId")]
public partial class AssuntosDoRoteiro
{
    /// <summary>
    /// Código que identifica o roteiro
    /// </summary>
    public int RoteiroId { get; set; }

    /// <summary>
    /// Ordem em que aparecem os roteiros
    /// </summary>
    public int Ordem { get; set; }

    /// <summary>
    /// Código que identifica o assunto
    /// </summary>
    public int AssuntoId { get; set; }

    [ForeignKey("AssuntoId")]
    public virtual Assunto Assunto { get; set; } = null!;

    [ForeignKey("RoteiroId")]
    public virtual Roteiro Roteiro { get; set; } = null!;
}
