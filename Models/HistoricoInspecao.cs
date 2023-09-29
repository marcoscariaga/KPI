using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("HistoricoInspecao")]
public partial class HistoricoInspecao
{
    [Key]
    public int Id { get; set; }

    public int TipoEventoId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataEvento { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Matricula { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string NumeroSisvisa { get; set; } = null!;

    public int? RequerenteId { get; set; }

    public int? HotelId { get; set; }

    public int? CrecheId { get; set; }

    public int? PiscinaId { get; set; }

    public int? OutroLocalId { get; set; }

    public int? UnidadePublicaSaudeId { get; set; }

    public int? EscolaMunicipalId { get; set; }

    public int? EstacaoTransportePublicoId { get; set; }

    [ForeignKey("CrecheId")]
    [InverseProperty("HistoricoInspecaos")]
    public virtual Creche? Creche { get; set; }

    [ForeignKey("EscolaMunicipalId")]
    [InverseProperty("HistoricoInspecaos")]
    public virtual EscolaMunicipal? EscolaMunicipal { get; set; }

    [ForeignKey("EstacaoTransportePublicoId")]
    [InverseProperty("HistoricoInspecaos")]
    public virtual EstacaoTransportePublico? EstacaoTransportePublico { get; set; }

    [ForeignKey("HotelId")]
    [InverseProperty("HistoricoInspecaos")]
    public virtual Hotel? Hotel { get; set; }

    [ForeignKey("OutroLocalId")]
    [InverseProperty("HistoricoInspecaos")]
    public virtual OutroLocal? OutroLocal { get; set; }

    [ForeignKey("PiscinaId")]
    [InverseProperty("HistoricoInspecaos")]
    public virtual Piscina? Piscina { get; set; }

    [ForeignKey("RequerenteId")]
    [InverseProperty("HistoricoInspecaos")]
    public virtual Requerente? Requerente { get; set; }

    [ForeignKey("UnidadePublicaSaudeId")]
    [InverseProperty("HistoricoInspecaos")]
    public virtual UnidadePublicaSaude? UnidadePublicaSaude { get; set; }
}
