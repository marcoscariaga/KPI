using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("RequerimentoAutodeclaracao")]
[Index("Numero", Name = "AK_NumeroDoProtocolo")]
[Index("EstabelecimentoId", Name = "IX_RequerimentoAutodeclaracao_EstabelecimentoId")]
[Index("JustificativaId", Name = "IX_RequerimentoAutodeclaracao_JustificativaId")]
[Index("SituacaoId", Name = "gqs_autodeclaracao")]
[Index("SituacaoId", Name = "gqs_requerimentoAutodeclaracao")]
public partial class RequerimentoAutodeclaracao
{
    /// <summary>
    /// Chave primária
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Login de rede
    /// </summary>
    [StringLength(256)]
    [Unicode(false)]
    public string? LoginDeRede { get; set; }

    /// <summary>
    /// Matrícula
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Matricula { get; set; }

    /// <summary>
    /// Número
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? Numero { get; set; }

    /// <summary>
    /// Data de início
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime DataInicio { get; set; }

    /// <summary>
    /// Data limite para envio
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime DataLimiteParaEnvio { get; set; }

    /// <summary>
    /// Data de fim
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? DataFim { get; set; }

    /// <summary>
    /// Data de envio
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? DataDeEnvio { get; set; }

    /// <summary>
    /// Data início da análise
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? DataInicioAnalise { get; set; }

    /// <summary>
    /// Data da exigência
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? DataExigencia { get; set; }

    /// <summary>
    /// Data limite para cumprimento de exigência
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? DataLimiteParaCumprimentoExigencia { get; set; }

    /// <summary>
    /// Dias para término da análise
    /// </summary>
    public int DiasParaTerminoDaAnalise { get; set; }

    /// <summary>
    /// 1-Requerimento de Licenciamento por Autodeclaração  2-Requerimento de Licenciamento
    /// </summary>
    public int TipoId { get; set; }

    /// <summary>
    /// 1-Autodeclaração  2-Simplificado  3-Tradicional
    /// </summary>
    public int LicenciamentoId { get; set; }

    /// <summary>
    /// 0-Novo  1-Preenchendo  2-Enviado  3-Exigência  4-Respondida  5-Análise  6-Analisado  7-Deferido  8-Indeferido  9-Cancelado
    /// </summary>
    public int SituacaoId { get; set; }

    /// <summary>
    /// Código do estabelecimento
    /// </summary>
    public int? EstabelecimentoId { get; set; }

    /// <summary>
    /// Código da justificativa
    /// </summary>
    public int? JustificativaId { get; set; }

    /// <summary>
    /// CPF
    /// </summary>
    public long Cpf { get; set; }

    /// <summary>
    /// Nome
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    /// <summary>
    /// Email
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    public string? ObservacaoInterna { get; set; }

    public string? Observacao { get; set; }

    [Column("ehResidencia")]
    public bool? EhResidencia { get; set; }

    public bool? EhSimplesEscritorio { get; set; }

    public bool? TemFuncionamentoNoLocal { get; set; }

    public bool? TemInternacao { get; set; }

    public bool? Supermercado { get; set; }

    public int? BancaJornalId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataPendenteLiberacaoFiscal { get; set; }

    public int? FeiranteId { get; set; }

    public int? AmbulanteId { get; set; }

    public int? SituacaoAnaliseDocumentalRepaId { get; set; }

    public bool TermoDeCienciaDaLegislacaoRepa { get; set; }

    public bool TermoDeResponsabilidadeRepa { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? JustificativaRepa { get; set; }

    public bool Mei { get; set; }

    public bool PequenosAgricultores { get; set; }

    public bool AgricultoresFamiliares { get; set; }

    public bool ProdutoresAgroecologicos { get; set; }

    public bool ProdutoresQuilombolas { get; set; }

    public int? TermoResponsabilidadeId { get; set; }

    public bool RealizaAbate { get; set; }

    public int? Complexidade { get; set; }

    public int? Risco { get; set; }

    public int? AreaOcupada { get; set; }

    public int? Periodo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataPrimeiroDownloadLicenca { get; set; }

    public int? SituacaoPrimeiroDownloadLicenca { get; set; }

    public bool Renovacao { get; set; }

    public int? TipoMotivoMudancaRepaId { get; set; }

    public bool? HouveMudancaRepa { get; set; }

    [InverseProperty("Requerimento")]
    public virtual ICollection<AcaoSisvisa> AcaoSisvisas { get; set; } = new List<AcaoSisvisa>();

    [ForeignKey("AmbulanteId")]
    [InverseProperty("RequerimentoAutodeclaracaos")]
    public virtual Ambulante? Ambulante { get; set; }

    [InverseProperty("Requerimento")]
    public virtual ICollection<Ambulante> Ambulantes { get; set; } = new List<Ambulante>();

    [InverseProperty("Requerimento")]
    public virtual ICollection<ArquivosRepa> ArquivosRepas { get; set; } = new List<ArquivosRepa>();

    [ForeignKey("BancaJornalId")]
    [InverseProperty("RequerimentoAutodeclaracaos")]
    public virtual BancaJornal? BancaJornal { get; set; }

    [ForeignKey("EstabelecimentoId")]
    [InverseProperty("RequerimentoAutodeclaracaos")]
    public virtual Estabelecimento? Estabelecimento { get; set; }

    [InverseProperty("Requerimento")]
    public virtual ICollection<Estabelecimento> Estabelecimentos { get; set; } = new List<Estabelecimento>();

    [InverseProperty("Requerimento")]
    public virtual ICollection<EventoAmbulante> EventoAmbulantes { get; set; } = new List<EventoAmbulante>();

    [InverseProperty("Requerimento")]
    public virtual ICollection<EventoBancaJornal> EventoBancaJornals { get; set; } = new List<EventoBancaJornal>();

    [InverseProperty("Requerimento")]
    public virtual ICollection<EventoEstabelecimento> EventoEstabelecimentos { get; set; } = new List<EventoEstabelecimento>();

    [InverseProperty("Requerimento")]
    public virtual ICollection<EventoFeirante> EventoFeirantes { get; set; } = new List<EventoFeirante>();

    [ForeignKey("FeiranteId")]
    [InverseProperty("RequerimentoAutodeclaracaos")]
    public virtual Feirante? Feirante { get; set; }

    [InverseProperty("Requerimento")]
    public virtual ICollection<Feirante> Feirantes { get; set; } = new List<Feirante>();

    [ForeignKey("JustificativaId")]
    [InverseProperty("RequerimentoAutodeclaracaos")]
    public virtual Justificativa? Justificativa { get; set; }

    [InverseProperty("Requerimento")]
    public virtual ICollection<RegistroRepa> RegistroRepas { get; set; } = new List<RegistroRepa>();

    [ForeignKey("TermoResponsabilidadeId")]
    [InverseProperty("RequerimentoAutodeclaracaos")]
    public virtual TermoResponsabilidade? TermoResponsabilidade { get; set; }

    [InverseProperty("UltimoRequerimentoLicencimento")]
    public virtual ICollection<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
}
