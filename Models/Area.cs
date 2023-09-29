using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Area")]
public partial class Area
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Valor { get; set; }

    public string Descricao { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal AreaMinima { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal AreaMaxima { get; set; }
}
