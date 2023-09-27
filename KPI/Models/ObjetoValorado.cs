using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[PrimaryKey("Tipo", "Valor")]
[Table("ObjetoValorado")]
public partial class ObjetoValorado
{
    [Key]
    [StringLength(250)]
    [Unicode(false)]
    public string Tipo { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    [Key]
    public int Valor { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Sigla { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Descricao { get; set; }
}
