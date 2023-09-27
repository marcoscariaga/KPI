using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("AssuntosDoModelo")]
[Index("AssuntoId", Name = "IX_AssuntosDoModelo_AssuntoId")]
[Index("ModeloRoteiroId", Name = "IX_AssuntosDoModelo_ModeloRoteiroId")]
public partial class AssuntosDoModelo
{
    /// <summary>
    /// Código que identifica o modelo do Roteiro.
    /// </summary>
    public int ModeloRoteiroId { get; set; }

    /// <summary>
    /// Ordem em que aparecem os assuntos do modelo
    /// </summary>
    public int Ordem { get; set; }

    /// <summary>
    /// Código que identifica o assunto
    /// </summary>
    public int AssuntoId { get; set; }

    [ForeignKey("AssuntoId")]
    public virtual Assunto Assunto { get; set; } = null!;

    [ForeignKey("ModeloRoteiroId")]
    public virtual ModeloRoteiro ModeloRoteiro { get; set; } = null!;
}
