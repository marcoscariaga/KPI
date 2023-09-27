using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("CapitulacaoLegalInspecao")]
[Index("LegislacaoId", Name = "UQ__Capitula__DDB370E82AC04CAA", IsUnique = true)]
public partial class CapitulacaoLegalInspecao
{
    [Key]
    public int Id { get; set; }

    public bool AtribuirParaTi { get; set; }

    public bool AtribuirParaEi { get; set; }

    public bool AtribuirParaNotificacaoInfracao { get; set; }

    public int LegislacaoId { get; set; }

    public bool AtribuirParaTa { get; set; }

    public bool AtribuirParaTaaa { get; set; }

    [ForeignKey("LegislacaoId")]
    [InverseProperty("CapitulacaoLegalInspecao")]
    public virtual Legislacao Legislacao { get; set; } = null!;

    [InverseProperty("CapitulacaoLegal")]
    public virtual ICollection<TermoApreensaoAmostraAnalise> TermoApreensaoAmostraAnalises { get; set; } = new List<TermoApreensaoAmostraAnalise>();

    [InverseProperty("CapitulacaoLegal")]
    public virtual ICollection<TermoApreensao> TermoApreensaos { get; set; } = new List<TermoApreensao>();
}
