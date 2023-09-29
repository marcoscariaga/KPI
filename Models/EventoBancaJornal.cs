using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("EventoBancaJornal")]
public partial class EventoBancaJornal
{
    [Key]
    public int Id { get; set; }

    public int TipoEventoId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataEvento { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Matricula { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string LoginRede { get; set; } = null!;

    public int BancaJornalId { get; set; }

    public int? RequerimentoId { get; set; }

    public int? JustificativaId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NumeroDocumento { get; set; }

    [ForeignKey("BancaJornalId")]
    [InverseProperty("EventoBancaJornals")]
    public virtual BancaJornal BancaJornal { get; set; } = null!;

    [ForeignKey("JustificativaId")]
    [InverseProperty("EventoBancaJornals")]
    public virtual Justificativa? Justificativa { get; set; }

    [ForeignKey("RequerimentoId")]
    [InverseProperty("EventoBancaJornals")]
    public virtual RequerimentoAutodeclaracao? Requerimento { get; set; }
}
