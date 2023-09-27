using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("AlimentoComercializado")]
public partial class AlimentoComercializado
{
    [Key]
    public int CodigoAlimento { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NomeAlimento { get; set; }
}
