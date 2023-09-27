using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("RequerimentoTransitorioAnexo")]
public partial class RequerimentoTransitorioAnexo
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CaminhoDoArquivo { get; set; } = null!;

    public int? TipoDeAnexo { get; set; }

    public int IdDoRequerimentoTransitorio { get; set; }
}
