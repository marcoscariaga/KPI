using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("ChancelaProcesso")]
public partial class ChancelaProcesso
{
    [StringLength(20)]
    [Unicode(false)]
    public string? NumeroProtocolo { get; set; }

    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CodigoDaValidacao { get; set; } = null!;

    public int? TipoDeProcesso { get; set; }
}
