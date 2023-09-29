using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
public partial class VwRestrdosRequautodecPosTi
{
    public int EstabelecimentoId { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Codigo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Descricao { get; set; }
}
