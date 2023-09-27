using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("HistoricoDeLicenca")]
[Index("NumeroDaLicenca", Name = "gqs_270421")]
[Index("EstabelecimentoId", Name = "gqs_id_estabelecimento")]
public partial class HistoricoDeLicenca
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NumeroDaLicenca { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDeCriacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDeValidade { get; set; }

    public int? EstabelecimentoId { get; set; }

    public int? SituacaoDaLicenca { get; set; }

    public int? JustificativaId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDeCancelamento { get; set; }

    public int? Complexidade { get; set; }

    public int? Risco { get; set; }

    public int? Area { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDeRevogacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCassacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataAnulacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataReativacao { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Motivo { get; set; }

    public int? BancaDeJornalId { get; set; }

    public int? FeiranteId { get; set; }

    public int? AmbulanteId { get; set; }

    public int? Licenciamento { get; set; }
}
