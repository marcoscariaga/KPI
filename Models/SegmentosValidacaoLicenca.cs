using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("SegmentosValidacaoLicenca")]
public partial class SegmentosValidacaoLicenca
{
    public int EstabelecimentoId { get; set; }

    public int SegmentoId { get; set; }

    public bool Aprovado { get; set; }

    [StringLength(256)]
    [Unicode(false)]
    public string? LoginDeRede { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Matricula { get; set; }

    [ForeignKey("EstabelecimentoId")]
    public virtual Estabelecimento Estabelecimento { get; set; } = null!;
}
