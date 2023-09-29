using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("HistoricoAtividadeEconomicaSinae")]
public partial class HistoricoAtividadeEconomicaSinae
{
    [Key]
    public int Id { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string Codigo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    public int? Situacao { get; set; }

    public int? Complexibilidade { get; set; }

    public int? Risco { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Fator { get; set; }

    public bool? Inspecao { get; set; }

    public bool? Asp { get; set; }

    public int? SegNegocio { get; set; }

    public bool? ExigRespTecnico { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string UsuarioMatricula { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DtAtualizacao { get; set; }

    public bool? Mei { get; set; }
}
