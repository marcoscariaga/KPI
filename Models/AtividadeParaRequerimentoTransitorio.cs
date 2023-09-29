using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("AtividadeParaRequerimentoTransitorio")]
public partial class AtividadeParaRequerimentoTransitorio
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string Codigo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? Descricao { get; set; }

    public int CodigoDaComplexidade { get; set; }

    public int CodigoDoRisco { get; set; }

    public int? TipoDeRequerente { get; set; }
}
