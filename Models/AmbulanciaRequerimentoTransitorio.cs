using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("AmbulanciaRequerimentoTransitorio")]
public partial class AmbulanciaRequerimentoTransitorio
{
    [Key]
    public int Id { get; set; }

    public int IdDoRequerimentoTransitorio { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Placa { get; set; } = null!;

    public int CodigoDaCategoria { get; set; }
}
