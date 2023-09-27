using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("SegmentosDoRequerimentoAdministrativo")]
public partial class SegmentosDoRequerimentoAdministrativo
{
    public int RequerimentoAdmId { get; set; }

    public int SegmentoId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataInicioDeferimento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataFimDeferimento { get; set; }

    public bool Aprovado { get; set; }

    [ForeignKey("RequerimentoAdmId")]
    public virtual RequerimentoAdministrativo RequerimentoAdm { get; set; } = null!;
}
