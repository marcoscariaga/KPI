using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("ArquivosREPA")]
public partial class ArquivosRepa
{
    [Key]
    public int Id { get; set; }

    public int RequerimentoId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Descricao { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NomeArquivo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataHoraUpload { get; set; }

    [ForeignKey("RequerimentoId")]
    [InverseProperty("ArquivosRepas")]
    public virtual RequerimentoAutodeclaracao Requerimento { get; set; } = null!;
}
