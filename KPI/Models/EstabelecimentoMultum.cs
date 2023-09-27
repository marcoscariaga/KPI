using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
public partial class EstabelecimentoMultum
{
    [Column("INSCRICAO")]
    public int? Inscricao { get; set; }
}
