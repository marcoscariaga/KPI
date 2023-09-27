using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("RequerimentoAdministrativo")]
[Index("TermoIntimacaoId", Name = "gqs_requerimentoadm")]
[Index("EstabelecimentoId", Name = "gqs_tls_estabelecimento")]
public partial class RequerimentoAdministrativo
{
    [Key]
    public int Id { get; set; }

    [StringLength(255)]
    public string TipoRequerimento { get; set; } = null!;

    public int TipoRequerimentoId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LoginDeRede { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MatriculaRequerimento { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string NumeroProcessoSicop { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataDeEnvio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataConclusao { get; set; }

    public string? Observacao { get; set; }

    public int SituacaoId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataLimiteParaEnvioComplemento { get; set; }

    public string? ObservacaoInterna { get; set; }

    public int? JustificativaId { get; set; }

    public int? EstabelecimentoId { get; set; }

    public int? RequerenteId { get; set; }

    public long Cpf { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? LocalPrestacaoDeServicoAtividade { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Tuap { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? NumeroProcesso { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Motivos { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? NumeroProcessoSisvisa { get; set; }

    public int? InscricaoMunicipal { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NomeRt { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CpfRt { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ProfissaoRt { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? EmailRt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TelefoneDeContatoRt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Telefone2Rt { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Matricula { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? CargoEmComissao { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? IngressarJuizoContra { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? InstruirAcao { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Nucleo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? NumeroDoProcesso { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? CargoEfetivo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? OrgaoAtividade { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Outras { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Secretaria { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? EstadoCivil { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Vara { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? VaraNumero { get; set; }

    public int? EstabelecimentoCifCiiId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ContaCorrente { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Contato { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? InscricaoEstadual { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? NomeAgencia { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NumeroAgencia { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? NomeBanco { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NumeroBanco { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PracaCompensacao { get; set; }

    public int? TipoDeDepositoId { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? PeriodoHorarioFuncionamento { get; set; }

    public int? QuantidadeRefeicoesTurno { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? LocalVistoria { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? NumerosProcedimentos { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ObjetivosProcedimentos { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DataEntrega { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? VeiculosDestinadosDistribuicao { get; set; }

    public int TipoEmpresaCarroPipaId { get; set; }

    public int TipoTermoId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NumeroDocumento { get; set; }

    public int? TermoIntimacaoId { get; set; }

    public int? TermoApreensaoId { get; set; }

    public int? TermoApreensaoAmostraAnaliseId { get; set; }

    public int? NotificacaoLaudoId { get; set; }

    public int? NotificacaoInfracaoId { get; set; }

    public bool? Mei { get; set; }

    public int? VeiculoId { get; set; }

    public int? IdMulta { get; set; }

    public int? TipoDeLicenciamentoId { get; set; }

    public int? BancaJornalId { get; set; }

    public int? TermoResponsabilidadeId { get; set; }

    public int? Complexidade { get; set; }

    public int? Risco { get; set; }

    public int? AreaOcupada { get; set; }

    public int? Periodo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataPrimeiroDownloadLicenca { get; set; }

    public int? SituacaoPrimeiroDownloadLicenca { get; set; }

    [InverseProperty("RequerimentoAdm")]
    public virtual ICollection<AcaoSisvisa> AcaoSisvisas { get; set; } = new List<AcaoSisvisa>();

    [InverseProperty("RequerimentoAdm")]
    public virtual ICollection<AutorizacaoSanitarium> AutorizacaoSanitaria { get; set; } = new List<AutorizacaoSanitarium>();

    [InverseProperty("RequerimentoAdm")]
    public virtual ICollection<ComplementoDeInformaco> ComplementoDeInformacos { get; set; } = new List<ComplementoDeInformaco>();

    [ForeignKey("EstabelecimentoId")]
    [InverseProperty("RequerimentoAdministrativoEstabelecimentos")]
    public virtual Estabelecimento? Estabelecimento { get; set; }

    [ForeignKey("EstabelecimentoCifCiiId")]
    [InverseProperty("RequerimentoAdministrativoEstabelecimentoCifCiis")]
    public virtual Estabelecimento? EstabelecimentoCifCii { get; set; }

    [InverseProperty("RequerimentoAdmRt")]
    public virtual ICollection<Estabelecimento> Estabelecimentos { get; set; } = new List<Estabelecimento>();

    [ForeignKey("IdMulta")]
    [InverseProperty("RequerimentoAdministrativos")]
    public virtual Multum? IdMultaNavigation { get; set; }

    [ForeignKey("JustificativaId")]
    [InverseProperty("RequerimentoAdministrativos")]
    public virtual Justificativa? Justificativa { get; set; }

    [ForeignKey("NotificacaoInfracaoId")]
    [InverseProperty("RequerimentoAdministrativos")]
    public virtual NotificacaoInfracao? NotificacaoInfracao { get; set; }

    [ForeignKey("NotificacaoLaudoId")]
    [InverseProperty("RequerimentoAdministrativos")]
    public virtual NotificacaoLaudo? NotificacaoLaudo { get; set; }

    [InverseProperty("RequerimentoAdm")]
    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();

    [ForeignKey("RequerenteId")]
    [InverseProperty("RequerimentoAdministrativos")]
    public virtual Requerente? Requerente { get; set; }

    [InverseProperty("RequerimentoAdm")]
    public virtual ICollection<Requerente> Requerentes { get; set; } = new List<Requerente>();

    [ForeignKey("TermoApreensaoId")]
    [InverseProperty("RequerimentoAdministrativos")]
    public virtual TermoApreensao? TermoApreensao { get; set; }

    [ForeignKey("TermoApreensaoAmostraAnaliseId")]
    [InverseProperty("RequerimentoAdministrativos")]
    public virtual TermoApreensaoAmostraAnalise? TermoApreensaoAmostraAnalise { get; set; }

    [ForeignKey("TermoIntimacaoId")]
    [InverseProperty("RequerimentoAdministrativos")]
    public virtual TermoIntimacao? TermoIntimacao { get; set; }

    [ForeignKey("TermoResponsabilidadeId")]
    [InverseProperty("RequerimentoAdministrativos")]
    public virtual TermoResponsabilidade? TermoResponsabilidade { get; set; }

    [ForeignKey("TipoDeLicenciamentoId")]
    [InverseProperty("RequerimentoAdministrativos")]
    public virtual TipoDeLicenciamento? TipoDeLicenciamento { get; set; }

    [ForeignKey("VeiculoId")]
    [InverseProperty("RequerimentoAdministrativos")]
    public virtual Veiculo? Veiculo { get; set; }

    [InverseProperty("UltimoRequerimentoAdministrativo")]
    public virtual ICollection<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
}
