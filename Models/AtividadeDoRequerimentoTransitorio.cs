using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("AtividadeDoRequerimentoTransitorio")]
public partial class AtividadeDoRequerimentoTransitorio
{
    [Key]
    public int Id { get; set; }

    public int IdDoRequerimentoTransitorio { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CodigoDaAtividadeDoRequerimentoTransitorio { get; set; } = null!;
}
