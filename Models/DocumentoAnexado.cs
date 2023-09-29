using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("DocumentoAnexado")]
public partial class DocumentoAnexado
{
    public int RequerimentoAdmId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NomeArquivo { get; set; }

    public int? TipoSituacaoId { get; set; }

    [ForeignKey("RequerimentoAdmId")]
    public virtual RequerimentoAdministrativo RequerimentoAdm { get; set; } = null!;
}
