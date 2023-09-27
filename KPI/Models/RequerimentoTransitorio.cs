using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("RequerimentoTransitorio")]
public partial class RequerimentoTransitorio
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Protocolo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataDoRequerimento { get; set; }

    [Column("CodigoDaCPE")]
    [StringLength(20)]
    [Unicode(false)]
    public string CodigoDaCpe { get; set; } = null!;

    [StringLength(100)]
    public string Email { get; set; } = null!;

    [Column("MEI")]
    public bool Mei { get; set; }

    public bool EnergiaEletrica { get; set; }

    public bool AguaEsgoto { get; set; }

    public bool InstalacaoGas { get; set; }

    public int CodigoDaArea { get; set; }

    public int CodigoDeQuantidadeDePessoas { get; set; }

    public int? Situacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDeInicio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDeFim { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CodigoDoRequerente { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? Outros { get; set; }

    public int? Tipo { get; set; }

    public int? Risco { get; set; }

    public int? Complexidade { get; set; }

    public int? TermoResponsabilidadeId { get; set; }

    public int? Periodo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataPrimeiroDownloadLicenca { get; set; }

    public int? SituacaoPrimeiroDownloadLicenca { get; set; }

    [ForeignKey("TermoResponsabilidadeId")]
    [InverseProperty("RequerimentoTransitorios")]
    public virtual TermoResponsabilidade? TermoResponsabilidade { get; set; }
}
