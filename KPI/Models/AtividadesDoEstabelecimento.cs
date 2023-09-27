using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("AtividadesDoEstabelecimento")]
[Index("EstabelecimentoId", Name = "IX_AtividadesDoEstabelecimento_EstabelecimentoId")]
[Index("EstabelecimentoId", "Codigo", Name = "UK_AtivEstabel_EstabelecimentoId_Codigo", IsUnique = true)]
public partial class AtividadesDoEstabelecimento
{
    /// <summary>
    /// Código que identifica o estabelecimento
    /// </summary>
    public int EstabelecimentoId { get; set; }

    /// <summary>
    /// Código da atividade no SINAE
    /// </summary>
    [StringLength(6)]
    [Unicode(false)]
    public string? Codigo { get; set; }

    /// <summary>
    /// Descrição da atividade
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? Descricao { get; set; }

    public bool? Licenciada { get; set; }

    public bool NecessitaComplemento { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Complemento { get; set; }

    public bool TemProcedimentoInvasivo { get; set; }

    public bool TemInvasivo { get; set; }

    [Column("afe")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Afe { get; set; }

    public bool? TemInternacao { get; set; }

    public bool? Regulada { get; set; }

    [ForeignKey("EstabelecimentoId")]
    public virtual Estabelecimento Estabelecimento { get; set; } = null!;
}
