using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("EventoFeirante")]
public partial class EventoFeirante
{
    [Key]
    public int Id { get; set; }

    public int? FeiranteId { get; set; }

    public int TipoEventoId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataEvento { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Matricula { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string LoginRede { get; set; } = null!;

    public int? RequerimentoId { get; set; }

    public int? JustificativaId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NumeroDocumento { get; set; }

    [ForeignKey("FeiranteId")]
    [InverseProperty("EventoFeirantes")]
    public virtual Feirante? Feirante { get; set; }

    [ForeignKey("JustificativaId")]
    [InverseProperty("EventoFeirantes")]
    public virtual Justificativa? Justificativa { get; set; }

    [ForeignKey("RequerimentoId")]
    [InverseProperty("EventoFeirantes")]
    public virtual RequerimentoAutodeclaracao? Requerimento { get; set; }
}
