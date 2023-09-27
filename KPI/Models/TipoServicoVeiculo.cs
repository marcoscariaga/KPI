using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("TipoServicoVeiculo")]
public partial class TipoServicoVeiculo
{
    public int Id { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    public int? FinalidadeVeiculoId { get; set; }

    public bool? Ativo { get; set; }
}
