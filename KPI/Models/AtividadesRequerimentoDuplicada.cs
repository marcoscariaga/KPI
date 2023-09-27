using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
public partial class AtividadesRequerimentoDuplicada
{
    [Column("Requerimento_id")]
    public int RequerimentoId { get; set; }

    [Column("Atividade_id")]
    public int AtividadeId { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Complemento { get; set; }
}
