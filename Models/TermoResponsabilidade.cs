using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("TermoResponsabilidade")]
public partial class TermoResponsabilidade
{
    [Key]
    public int Id { get; set; }

    public int TipoTermoLicenciamentoId { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    public bool Ativo { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string Titulo { get; set; } = null!;

    [InverseProperty("TermoResponsabilidade")]
    public virtual ICollection<RequerimentoAdministrativo> RequerimentoAdministrativos { get; set; } = new List<RequerimentoAdministrativo>();

    [InverseProperty("TermoResponsabilidade")]
    public virtual ICollection<RequerimentoAutodeclaracao> RequerimentoAutodeclaracaos { get; set; } = new List<RequerimentoAutodeclaracao>();

    [InverseProperty("TermoResponsabilidade")]
    public virtual ICollection<RequerimentoTransitorio> RequerimentoTransitorios { get; set; } = new List<RequerimentoTransitorio>();

    [ForeignKey("TipoTermoLicenciamentoId")]
    [InverseProperty("TermoResponsabilidades")]
    public virtual TipoTermoLicenciamento TipoTermoLicenciamento { get; set; } = null!;
}
