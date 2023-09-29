using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("LogDePagamento")]
public partial class LogDePagamento
{
    [Key]
    public int Id { get; set; }

    public int? CodigoDaGuia { get; set; }

    public int? CodigoDeReceita { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Data { get; set; }
}
