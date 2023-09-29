using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
public partial class VwAtivDoRequAutodecPosTi
{
    public int EstabelecimentoId { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? Codigo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Descricao { get; set; }

    public bool? Licenciada { get; set; }

    public bool NecessitaComplemento { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Complemento { get; set; }

    public bool TemProcedimentoInvasivo { get; set; }

    public bool TemInvasivo { get; set; }

    [Column("afe")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Afe { get; set; }

    public bool? TemInternacao { get; set; }
}
