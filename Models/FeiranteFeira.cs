using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("FeiranteFeira")]
public partial class FeiranteFeira
{
    [Key]
    public int Id { get; set; }

    public int? FeiranteId { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string DiaFeira { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? Situacao { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Descricao { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Logradouro { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Bairro { get; set; }

    public bool Manha { get; set; }

    public bool Tarde { get; set; }

    public bool Noite { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OutrosHorarios { get; set; }

    [ForeignKey("FeiranteId")]
    [InverseProperty("FeiranteFeiras")]
    public virtual Feirante? Feirante { get; set; }

    [InverseProperty("FeiranteFeira")]
    public virtual ICollection<PosicaoFeiranteFeira> PosicaoFeiranteFeiras { get; set; } = new List<PosicaoFeiranteFeira>();
}
