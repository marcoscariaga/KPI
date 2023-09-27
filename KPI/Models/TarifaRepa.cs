using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("TarifaREPA")]
public partial class TarifaRepa
{
    [Key]
    public int Id { get; set; }

    public int Complexidade { get; set; }

    public int Risco { get; set; }

    public int Area { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal Valor { get; set; }
}
