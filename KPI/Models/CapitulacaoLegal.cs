using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("CapitulacaoLegal")]
[Index("LegislacaoId", Name = "IX_CapitulacaoLegal_LegislacaoId")]
[Index("PerguntaId", Name = "IX_CapitulacaoLegal_PerguntaId")]
[Index("PerguntaId", "LegislacaoId", Name = "UQ__Capitula__8F94FB2B4CC05EF3", IsUnique = true)]
public partial class CapitulacaoLegal
{
    public int PerguntaId { get; set; }

    public int Ordem { get; set; }

    public int LegislacaoId { get; set; }

    [ForeignKey("LegislacaoId")]
    public virtual Legislacao Legislacao { get; set; } = null!;

    [ForeignKey("PerguntaId")]
    public virtual Perguntum Pergunta { get; set; } = null!;
}
