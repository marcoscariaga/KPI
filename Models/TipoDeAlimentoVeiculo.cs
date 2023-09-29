using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("TipoDeAlimentoVeiculo")]
public partial class TipoDeAlimentoVeiculo
{
    public int Id { get; set; }

    public int? TipoDeVeiculoId { get; set; }

    public int? SegmentoId { get; set; }

    public bool? Situacao { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Nome { get; set; }
}
