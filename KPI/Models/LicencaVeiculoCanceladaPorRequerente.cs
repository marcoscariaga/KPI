using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("LicencaVeiculoCanceladaPorRequerente")]
public partial class LicencaVeiculoCanceladaPorRequerente
{
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ProtocoloCancelado { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ProtocoloCancelamento { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataCancelamento { get; set; }

    public int? JustificativaId { get; set; }

    public int? IdVeiculo { get; set; }
}
