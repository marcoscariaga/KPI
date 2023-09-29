using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("RestricoesDoEstabelecimento")]
[Index("EstabelecimentoId", Name = "IX_RestricoesDoEstabelecimento_EstabelecimentoId")]
public partial class RestricoesDoEstabelecimento
{
    /// <summary>
    /// Estabelecimento
    /// </summary>
    public int EstabelecimentoId { get; set; }

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? Codigo { get; set; }

    /// <summary>
    /// Descrição
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? Descricao { get; set; }

    [ForeignKey("EstabelecimentoId")]
    public virtual Estabelecimento Estabelecimento { get; set; } = null!;
}
