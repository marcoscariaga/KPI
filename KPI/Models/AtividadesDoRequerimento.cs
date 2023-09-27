using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("AtividadesDoRequerimento")]
[Index("AtividadeId", Name = "IX_AtividadesDoRequerimento_Atividade_id")]
[Index("RequerimentoId", Name = "IX_AtividadesDoRequerimento_Requerimento_id")]
[Index("RequerimentoId", "AtividadeId", Name = "UQ__Atividad__8DCB2A3538C4533E", IsUnique = true)]
public partial class AtividadesDoRequerimento
{
    /// <summary>
    /// Código que identifica o requerimento
    /// </summary>
    [Column("Requerimento_id")]
    public int RequerimentoId { get; set; }

    /// <summary>
    /// Código que identifica a atividade
    /// </summary>
    [Column("Atividade_id")]
    public int AtividadeId { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Complemento { get; set; }

    [ForeignKey("AtividadeId")]
    public virtual Atividade Atividade { get; set; } = null!;

    [ForeignKey("RequerimentoId")]
    public virtual RequerimentoAutodeclaracao Requerimento { get; set; } = null!;
}
