using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("LicencaDeVeiculo")]
public partial class LicencaDeVeiculo
{
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string NumeroDaLicenca { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataDeCriacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataDeConcessao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDeValidade { get; set; }

    public int VeiculoId { get; set; }

    public int SituacaoDaLicenca { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDeCancelamento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDeRevogacao { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? MotivoRevogacao { get; set; }

    public int? Complexidade { get; set; }

    public int? Risco { get; set; }

    public int? Area { get; set; }

    public int RequerimentoAdministrativoId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDeCassacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDeAnulacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataAnulacaoLimite { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? MotivoAnulacaoCassacao { get; set; }

    [ForeignKey("RequerimentoAdministrativoId")]
    public virtual RequerimentoAdministrativo RequerimentoAdministrativo { get; set; } = null!;

    [ForeignKey("VeiculoId")]
    public virtual Veiculo Veiculo { get; set; } = null!;
}
