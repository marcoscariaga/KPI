using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("HistoricoFeiranteFeira")]
public partial class HistoricoFeiranteFeira
{
    [Key]
    public int Id { get; set; }

    public int? HistoricoFeiranteId { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? DiaFeira { get; set; }

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

    [ForeignKey("HistoricoFeiranteId")]
    [InverseProperty("HistoricoFeiranteFeiras")]
    public virtual HistoricoFeirante? HistoricoFeirante { get; set; }
}
