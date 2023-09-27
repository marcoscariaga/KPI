using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Estabelecimento")]
[Index("CpfCnpj", Name = "IX_Estabelecimento_CpfCnpj")]
[Index("NomeFantasia", Name = "IX_Estabelecimento_NomeFantasia")]
[Index("RequerimentoId", Name = "IX_Estabelecimento_RequerimentoId")]
[Index("InscricaoMunicipal", Name = "UQ__Estabele__DC2FA3BF0A688BB1", IsUnique = true)]
[Index("SituacaoDaLicencaSanitaria", "TipoLicenca", "SituacaoValidacaoDaLicencaSanitaria", Name = "gqs_estabelecimento")]
public partial class Estabelecimento
{
    /// <summary>
    /// Código que identifica o estabelecimento
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Número da Inscrição Municipal
    /// </summary>
    public int InscricaoMunicipal { get; set; }

    /// <summary>
    /// Número do CPF ou CNPJ
    /// </summary>
    [StringLength(14)]
    [Unicode(false)]
    public string CpfCnpj { get; set; } = null!;

    /// <summary>
    /// Nome fantasia relativo ao CPF/CNPJ
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? NomeFantasia { get; set; }

    /// <summary>
    /// Nome da razão social relativo ao CPF/CNPJ
    /// </summary>
    [StringLength(300)]
    [Unicode(false)]
    public string? RazaoSocial { get; set; }

    /// <summary>
    /// Metragem da área ocupada pelo estabelecimento
    /// </summary>
    [Column(TypeName = "decimal(19, 5)")]
    public decimal AreaOcupada { get; set; }

    /// <summary>
    /// Descrição da situação da Inscrição Municipal existente no SINAE
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string SituacaoDoAlvara { get; set; } = null!;

    /// <summary>
    /// Identifica se o estabelecimento está ativo no SISVISA. Valores: [1/0]
    /// </summary>
    public bool Ativo { get; set; }

    /// <summary>
    /// Identifica se o estabelecimento funciona no período da manhã. Valores: Valores: [1/0]
    /// </summary>
    public bool Manha { get; set; }

    /// <summary>
    /// Identifica se o estabelecimento funciona no período da tarde. Valores: Valores: [1/0]
    /// </summary>
    public bool Tarde { get; set; }

    /// <summary>
    /// Identifica se o estabelecimento funciona no período da noite. Valores: Valores: [1/0]
    /// </summary>
    public bool Noite { get; set; }

    /// <summary>
    /// Identifica se o estabelecimento funciona na Segunda-feira. Valores: Valores: [1/0]
    /// </summary>
    public bool Segunda { get; set; }

    /// <summary>
    /// Identifica se o estabelecimento funciona na Terça-feira. Valores: Valores: [1/0]
    /// </summary>
    public bool Terca { get; set; }

    /// <summary>
    /// Identifica se o estabelecimento funciona na Quarta-feira. Valores: Valores: [1/0]
    /// </summary>
    public bool Quarta { get; set; }

    /// <summary>
    /// Identifica se o estabelecimento funciona na Quinta-feira. Valores: Valores: [1/0]
    /// </summary>
    public bool Quinta { get; set; }

    /// <summary>
    /// Identifica se o estabelecimento funciona na Sexta-feira. Valores: Valores: [1/0]
    /// </summary>
    public bool Sexta { get; set; }

    /// <summary>
    /// Identifica se o estabelecimento funciona no Sábado. Valores: Valores: [1/0]
    /// </summary>
    public bool Sabado { get; set; }

    /// <summary>
    /// Identifica se o estabelecimento funciona no Domingo. Valores: Valores: [1/0]
    /// </summary>
    public bool Domingo { get; set; }

    /// <summary>
    /// Identifica se o estabelecimento funciona no Feriado. Valores: Valores: [1/0]
    /// </summary>
    public bool Feriados { get; set; }

    /// <summary>
    /// Descreve a latitude da localização do estabelecimento
    /// </summary>
    [Column(TypeName = "decimal(9, 7)")]
    public decimal Latitude { get; set; }

    /// <summary>
    /// Descreve a longitude da localização do estabelecimento
    /// </summary>
    [Column(TypeName = "decimal(9, 7)")]
    public decimal Longitude { get; set; }

    /// <summary>
    /// Descreve a Região Administrativa na qual o estabelecimento se localiza
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? Ra { get; set; }

    /// <summary>
    /// Descreve o bairro onde o estabelecimento se localiza
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? BairroDaLocalizacao { get; set; }

    /// <summary>
    /// identifica os estabelecimentos que foram preenchidos pelo serviço SINAE ou preenchido manualmente pelo funcionário. Valores: [1/0]
    /// </summary>
    public bool PreenchidoPeloServico { get; set; }

    /// <summary>
    /// Endereço para a localização do estabelecimento
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string Logradouro { get; set; } = null!;

    /// <summary>
    /// Representa o tipo do logradouro para a localização do estabelecimento. Ex:travessa, viela, viaduto...
    /// </summary>
    [StringLength(3)]
    [Unicode(false)]
    public string? TipoLogradouro { get; set; }

    /// <summary>
    /// Código que identifica o tipo de Logradouro. Ex: Acesso. 002, Alameda. 005...
    /// </summary>
    [StringLength(6)]
    [Unicode(false)]
    public string? CodigoLogradouro { get; set; }

    /// <summary>
    /// Número do endereço onde o estabelecimento se localiza
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string Numero { get; set; } = null!;

    /// <summary>
    /// Complemento do endereço onde o estabelecimento se localiza
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? Complemento { get; set; }

    /// <summary>
    /// Descreve o bairro onde o estabelecimento se localiza
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? Bairro { get; set; }

    /// <summary>
    /// Cinco primeiros números do CEP onde o estabelecimento se localiza
    /// </summary>
    public int CepNumero { get; set; }

    /// <summary>
    /// Três últimos números do CEP onde o estabelecimento se localiza
    /// </summary>
    public short CepComplemento { get; set; }

    /// <summary>
    /// Número da licença para funcionamento do estabelecimento
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? NumeroLicenca { get; set; }

    /// <summary>
    /// Número da autenticação da licença do estabelecimento
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? NumeroDeAutenticacao { get; set; }

    /// <summary>
    /// Data da criação da licença do estabelecimento
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? DataCriacao { get; set; }

    /// <summary>
    /// Data de validade da licença do estabelecimento
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? DataValidade { get; set; }

    /// <summary>
    /// Situação da licença sanitária
    /// </summary>
    public int SituacaoDaLicencaSanitaria { get; set; }

    /// <summary>
    /// Código que identifica o requerimento
    /// </summary>
    public int? RequerimentoId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCancelamento { get; set; }

    public int? JustificativaId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OutrosHorarios { get; set; }

    public bool? Lss { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TelefoneDeContato { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Telefone2 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDaInclusao { get; set; }

    public int SegmentoId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Cidade { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Uf { get; set; } = null!;

    public int TipoLicenca { get; set; }

    public int SituacaoValidacaoDaLicencaSanitaria { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NumeroProcesso { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataRevogacao { get; set; }

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

    [StringLength(200)]
    [Unicode(false)]
    public string? AnexoIdentificacaoRt { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? AnexoVinculoResponsabilidadeRt { get; set; }

    public int? SituacaoDocumentoRtId { get; set; }

    public int? SituacaoCadastroRtId { get; set; }

    public int? RequerimentoAdmRtId { get; set; }

    public bool? TermoDeResponsabilidade { get; set; }

    public bool? TermoDeCienciaDaLegislacao { get; set; }

    public bool? Mei { get; set; }

    public bool? TermoAceite { get; set; }

    public int? SituacaoDaEmissaoDaLicenca { get; set; }

    public int? Complexidade { get; set; }

    public int? Risco { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDaOndaParaLicenca { get; set; }

    public bool? Supermercado { get; set; }

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

    [InverseProperty("Estabelecimento")]
    public virtual ICollection<AcaoSisvisa> AcaoSisvisas { get; set; } = new List<AcaoSisvisa>();

    [InverseProperty("Estabelecimento")]
    public virtual ICollection<EventoEstabelecimento> EventoEstabelecimentos { get; set; } = new List<EventoEstabelecimento>();

    [ForeignKey("JustificativaId")]
    [InverseProperty("Estabelecimentos")]
    public virtual Justificativa? Justificativa { get; set; }

    [InverseProperty("Estabelecimento")]
    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();

    [ForeignKey("RequerimentoId")]
    [InverseProperty("Estabelecimentos")]
    public virtual RequerimentoAutodeclaracao? Requerimento { get; set; }

    [ForeignKey("RequerimentoAdmRtId")]
    [InverseProperty("Estabelecimentos")]
    public virtual RequerimentoAdministrativo? RequerimentoAdmRt { get; set; }

    [InverseProperty("EstabelecimentoCifCii")]
    public virtual ICollection<RequerimentoAdministrativo> RequerimentoAdministrativoEstabelecimentoCifCiis { get; set; } = new List<RequerimentoAdministrativo>();

    [InverseProperty("Estabelecimento")]
    public virtual ICollection<RequerimentoAdministrativo> RequerimentoAdministrativoEstabelecimentos { get; set; } = new List<RequerimentoAdministrativo>();

    [InverseProperty("Estabelecimento")]
    public virtual ICollection<RequerimentoAutodeclaracao> RequerimentoAutodeclaracaos { get; set; } = new List<RequerimentoAutodeclaracao>();

    [InverseProperty("Estabelecimento")]
    public virtual ICollection<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
}
