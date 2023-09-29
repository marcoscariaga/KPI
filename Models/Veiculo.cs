using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Veiculo")]
public partial class Veiculo
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string NomeProprietario { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Placa { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Renavam { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Cidade { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Uf { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? NumeroLicenca { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NumeroDeAutorizacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataCriacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataValidade { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataConcessao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataRevogacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCancelamento { get; set; }

    public int? SituacaoDaLicencaVeiculoId { get; set; }

    public int? SituacaoDaAutorizacaoVeiculoId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string AnexoDocumento { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? AnexoDocumentoComplemento { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? DocumentoRioTur { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? DocumentoDeBaixa { get; set; }

    public int SituacaoAnexoDocumentoVeiculoId { get; set; }

    public int SituacaoCadastroVeiculoId { get; set; }

    public int? TipoProprietarioId { get; set; }

    public int? RequerenteId { get; set; }

    public int? EstabelecimentoId { get; set; }

    public int TipoVeiculoId { get; set; }

    public int? UltimoRequerimentoLicencimentoId { get; set; }

    public int? UltimoRequerimentoAdministrativoId { get; set; }

    public bool TodasRespostasRoteiroComParecer { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NomeTerceirizada { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CnpjTerceirizada { get; set; }

    public bool? Mei { get; set; }

    public bool? Comlurb { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? AnoFabricacao { get; set; }

    public int? SegmentoId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? MotivoRevogacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCassacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataAnulacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataAnulacaoLimite { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? MotivoAnulacaoCassacao { get; set; }

    [ForeignKey("EstabelecimentoId")]
    [InverseProperty("Veiculos")]
    public virtual Estabelecimento? Estabelecimento { get; set; }

    [ForeignKey("RequerenteId")]
    [InverseProperty("Veiculos")]
    public virtual Requerente? Requerente { get; set; }

    [InverseProperty("Veiculo")]
    public virtual ICollection<RequerimentoAdministrativo> RequerimentoAdministrativos { get; set; } = new List<RequerimentoAdministrativo>();

    [ForeignKey("TipoVeiculoId")]
    [InverseProperty("Veiculos")]
    public virtual TipoVeiculo TipoVeiculo { get; set; } = null!;

    [ForeignKey("UltimoRequerimentoAdministrativoId")]
    [InverseProperty("Veiculos")]
    public virtual RequerimentoAdministrativo? UltimoRequerimentoAdministrativo { get; set; }

    [ForeignKey("UltimoRequerimentoLicencimentoId")]
    [InverseProperty("Veiculos")]
    public virtual RequerimentoAutodeclaracao? UltimoRequerimentoLicencimento { get; set; }
}
