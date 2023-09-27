using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("ModeloDeDarm")]
public partial class ModeloDeDarm
{
    [Key]
    public int Id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CodigoDaReceita { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string CodigoDaReceitaDigito { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string CodigoDeProduto { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string CodigoDaEmpresa { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string CodigoDaPrefeitura { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string CodigoDaMoeda { get; set; } = null!;

    public int TipoDeDarm { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string TextoDoDarm { get; set; } = null!;
}
