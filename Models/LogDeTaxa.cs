using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("LogDeTaxa")]
public partial class LogDeTaxa
{
    [Key]
    public int Id { get; set; }

    public int Tipo { get; set; }

    public int Periodo { get; set; }

    public int Risco { get; set; }

    public int Complexidade { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Area { get; set; }

    public bool Mei { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ValorDaTaxa { get; set; }

    public bool Multa { get; set; }
}
