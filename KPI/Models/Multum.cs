using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Index("InscricaoMunicipalAutuado", Name = "gqs_cargaSisvisa")]
public partial class Multum
{
    [Key]
    public int Id { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string InformacaoComplementar { get; set; } = null!;

    [StringLength(60)]
    [Unicode(false)]
    public string? NomeSecretaria { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? OrgaoAtuante { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string CpfCnpj { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? MatriculaAtuante { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? NomeAtuante { get; set; }

    public int? NumeroAuto { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? InscricaoMunicipalAutuado { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string NomeRequerente { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? DocumentoRequerente { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Endereco { get; set; } = null!;

    [StringLength(6)]
    [Unicode(false)]
    public string? NumeroEndereco { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? EnderecoComplemento { get; set; }

    [Column("enderecoComplementoSuplementar")]
    [StringLength(20)]
    [Unicode(false)]
    public string? EnderecoComplementoSuplementar { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string Bairro { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Municipio { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string Cep { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Uf { get; set; } = null!;

    [StringLength(220)]
    [Unicode(false)]
    public string? CapitulacaoLegal { get; set; }

    [StringLength(220)]
    [Unicode(false)]
    public string? AutoInfracao { get; set; }

    [StringLength(220)]
    [Unicode(false)]
    public string? PenalidadeInfracao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataInfracao { get; set; }

    [StringLength(220)]
    [Unicode(false)]
    public string? LocalInfracao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataLavraturaInfracao { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string MoedaMonetaria { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? NumeroProcesso { get; set; }

    public int? Orgao { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CodigoDoLogradouro { get; set; }

    public int? Situacao { get; set; }

    public int? NumeroDaGuia { get; set; }

    public int? IdTipoDeLicenciamento { get; set; }

    public int? IdCaptulacaoLegal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDaAlteracao { get; set; }

    [Column(TypeName = "numeric(11, 2)")]
    public decimal? ValorInfracao { get; set; }

    public int? RequerimentoAdministrativoId { get; set; }

    public int? RequerimentoTransitorioId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MatriculaServidorAssinatura { get; set; }

    public int? IdMultaSubstituto { get; set; }

    public int? NumeroDaLinha { get; set; }

    [Column("CPE")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Cpe { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? Placa { get; set; }

    public int? IdArquivoExtracao { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? LinhaDigitacaoObjeto { get; set; }

    [Column("LinhaDigitacaoAR")]
    [StringLength(13)]
    [Unicode(false)]
    public string? LinhaDigitacaoAr { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NomeArquivo { get; set; }

    public int? SequencialArquivo { get; set; }

    public int? Periodo { get; set; }

    public int? Risco { get; set; }

    public int? Complexidade { get; set; }

    public int? CodigoDaArea { get; set; }

    [InverseProperty("IdMultaNavigation")]
    public virtual ICollection<AutoInfracaoAssinado> AutoInfracaoAssinados { get; set; } = new List<AutoInfracaoAssinado>();

    [ForeignKey("IdArquivoExtracao")]
    [InverseProperty("Multa")]
    public virtual ArquivoExtracaoMultum? IdArquivoExtracaoNavigation { get; set; }

    [ForeignKey("IdTipoDeLicenciamento")]
    [InverseProperty("Multa")]
    public virtual TipoDeLicenciamento? IdTipoDeLicenciamentoNavigation { get; set; }

    public virtual Servidor? MatriculaServidorAssinaturaNavigation { get; set; }

    [InverseProperty("IdMultaNavigation")]
    public virtual ICollection<RequerimentoAdministrativo> RequerimentoAdministrativos { get; set; } = new List<RequerimentoAdministrativo>();
}
