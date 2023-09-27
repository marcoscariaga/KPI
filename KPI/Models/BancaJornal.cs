using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("BancaJornal")]
public partial class BancaJornal
{
    [Key]
    public int Id { get; set; }

    public int? AutorizacaoId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? InscricaoMunicipal { get; set; }

    [Column("CPFTitular")]
    [StringLength(18)]
    [Unicode(false)]
    public string? Cpftitular { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NomeTitular { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? CodigoLogradouroTitular { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LogradouroTitular { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NumeroPortaTitular { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ComplementoTitular { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BairroTitular { get; set; }

    [Column("CEPTitular")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Ceptitular { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MunicipioTitular { get; set; }

    [Column("UFTitular")]
    [StringLength(2)]
    [Unicode(false)]
    public string? Uftitular { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? TelefoneTitular { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? CelularTitular { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? EmailTitular { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? CodigoLogradouroBanca { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LogradouroBanca { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferenciaBanca { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NumeroPortaBanca { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ComplementoBanca { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BairroBanca { get; set; }

    [Column("CEPBanca")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Cepbanca { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? AreaUtil { get; set; }

    public bool? Mei { get; set; }

    [Column("DimensaoFrenteBanca_CM")]
    [StringLength(10)]
    [Unicode(false)]
    public string? DimensaoFrenteBancaCm { get; set; }

    [Column("DimensaoLateralBanca_CM")]
    [StringLength(10)]
    [Unicode(false)]
    public string? DimensaoLateralBancaCm { get; set; }

    [Column("DimensaoAlturaBanca_CM")]
    [StringLength(10)]
    [Unicode(false)]
    public string? DimensaoAlturaBancaCm { get; set; }

    [Column("requerimentoId")]
    public int? RequerimentoId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Situacao { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Operacao { get; set; }

    public int? AtividadeId { get; set; }

    public bool Domingo { get; set; }

    public bool Segunda { get; set; }

    public bool Terca { get; set; }

    public bool Quarta { get; set; }

    public bool Quinta { get; set; }

    public bool Sexta { get; set; }

    public bool Sabado { get; set; }

    public bool Feriados { get; set; }

    public bool Manha { get; set; }

    public bool Tarde { get; set; }

    public bool Noite { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OutrosHorarios { get; set; }

    public int Complexidade { get; set; }

    public int Risco { get; set; }

    public bool Ativo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataInclusao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataAlteracao { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MatriculaUsuarioAlteracao { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MotivoAlteracao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDaOndaParaLicenca { get; set; }

    public bool? TermoDeCienciaDaLegislacao { get; set; }

    public bool? TermoDeResponsabilidade { get; set; }

    public int? SituacaoDaEmissaoDaLicenca { get; set; }

    public int? TipoLicenca { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NumeroLicenca { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SituacaoDoAlvara { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NumeroDeAutenticacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCriacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataValidade { get; set; }

    public int? SituacaoDaLicencaSanitaria { get; set; }

    public int? SituacaoValidacaoDaLicencaSanitaria { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NumeroProcesso { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataRevogacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCancelamento { get; set; }

    public int? JustificativaId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCassacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataAnulacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataAnulacaoLimite { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataReativacao { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Motivo { get; set; }

    [InverseProperty("IdBancaJornalNavigation")]
    public virtual ICollection<BancaJornalProdutoBancaJornal> BancaJornalProdutoBancaJornals { get; set; } = new List<BancaJornalProdutoBancaJornal>();

    [InverseProperty("BancaJornal")]
    public virtual ICollection<EventoBancaJornal> EventoBancaJornals { get; set; } = new List<EventoBancaJornal>();

    [InverseProperty("BancaJornal")]
    public virtual ICollection<RequerimentoAutodeclaracao> RequerimentoAutodeclaracaos { get; set; } = new List<RequerimentoAutodeclaracao>();
}
