using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("EventoEstabelecimento")]
[Index("EstabelecimentoId", Name = "gqs_carga-1")]
public partial class EventoEstabelecimento
{
    [Key]
    public int Id { get; set; }

    public int TipoEventoId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataEvento { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Matricula { get; set; } = null!;

    [StringLength(256)]
    [Unicode(false)]
    public string LoginRede { get; set; } = null!;

    public int EstabelecimentoId { get; set; }

    public int? RequerimentoId { get; set; }

    public int? JustificativaId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NumeroDocumento { get; set; }

    [ForeignKey("EstabelecimentoId")]
    [InverseProperty("EventoEstabelecimentos")]
    public virtual Estabelecimento Estabelecimento { get; set; } = null!;

    [ForeignKey("JustificativaId")]
    [InverseProperty("EventoEstabelecimentos")]
    public virtual Justificativa? Justificativa { get; set; }

    [ForeignKey("RequerimentoId")]
    [InverseProperty("EventoEstabelecimentos")]
    public virtual RequerimentoAutodeclaracao? Requerimento { get; set; }
}
