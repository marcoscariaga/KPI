using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("PosicaoFeiranteFeira")]
public partial class PosicaoFeiranteFeira
{
    public int FeiranteFeiraId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Posicao { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Lado { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Marca { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Turno { get; set; }

    [Key]
    public int Id { get; set; }

    [ForeignKey("FeiranteFeiraId")]
    [InverseProperty("PosicaoFeiranteFeiras")]
    public virtual FeiranteFeira FeiranteFeira { get; set; } = null!;
}
