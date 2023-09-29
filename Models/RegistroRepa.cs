using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("RegistroREPA")]
public partial class RegistroRepa
{
    [Key]
    public int Id { get; set; }

    public int RequerimentoId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataAlteracao { get; set; }

    public int? SituacaoId { get; set; }

    public int? TipoLicenca { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NumeroLicenca { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCriacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataValidade { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataRevogacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCancelamento { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Justificativa { get; set; }

    public int? NumeroProcesso { get; set; }

    [ForeignKey("RequerimentoId")]
    [InverseProperty("RegistroRepas")]
    public virtual RequerimentoAutodeclaracao Requerimento { get; set; } = null!;
}
