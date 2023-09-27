using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("FinalidadeVeiculo")]
public partial class FinalidadeVeiculo
{
    [StringLength(200)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    public int AreaAtividade { get; set; }

    public int TipoComplexidade { get; set; }

    public int TipoRisco { get; set; }

    public bool? Ativo { get; set; }

    public int Id { get; set; }
}
