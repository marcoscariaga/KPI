using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("AcaoSisvisa")]
[Index("SegmentoDeInspecaoId", Name = "gqs_280421")]
[Index("SegmentoDeInspecaoId", "SituacaoDemanda", "TipoAcaoSisvisaId", Name = "gqs_acaoSisvisa")]
[Index("EstabelecimentoId", Name = "gqs_tls_estabelecimentoId")]
public partial class AcaoSisvisa
{
    [Key]
    public int Id { get; set; }

    public int TipoAcaoSisvisaId { get; set; }

    public int SegmentoDeInspecaoId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NumeroOficio { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NumChamado1746 { get; set; }

    public int SituacaoDemanda { get; set; }

    public string? MotivoReinspecao { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? Observacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataCriacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataConclusao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataInicioAtendimento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataTerminoAtendimento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataUltimaAtualizacao { get; set; }

    [StringLength(256)]
    [Unicode(false)]
    public string? LoginServidor { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MatriculaServidor { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Descricao { get; set; }

    [StringLength(516)]
    [Unicode(false)]
    public string? ArquivoAnexado { get; set; }

    public int? RequerimentoId { get; set; }

    public int? RequerimentoAdmId { get; set; }

    public int? EstabelecimentoId { get; set; }

    public int? RequerenteId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Logradouro { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string? TipoLogradouro { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? CodigoLogradouro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Numero { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Complemento { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Bairro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Cidade { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Uf { get; set; } = null!;

    public int CepNumero { get; set; }

    public short CepComplemento { get; set; }

    public string? ObservacaoInterna { get; set; }

    public int PrioridadeId { get; set; }

    public double? DistanciaDaAp { get; set; }

    public bool? Atendida { get; set; }

    public bool? GeraVisitaSanitaria { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Gerencia { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? RazaoSocialNomeLocalVisita { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CnpjLocalVisita { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NumeroGal { get; set; }

    public int? HotelId { get; set; }

    public int? PiscinaId { get; set; }

    public int? CrecheId { get; set; }

    public int? EscolaMunicipalId { get; set; }

    public int? UnidadePublicaSaudeId { get; set; }

    public int? OutroLocalId { get; set; }

    public int? EstacaoTransportePublicoId { get; set; }

    public int? ProgramaId { get; set; }

    public int? ConfiguracaoProgramaColetaAmostrasProdutosId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? InscricaoMunicipalLocalVisita { get; set; }

    public int? PontoColetaVigiaguaId { get; set; }

    public bool PossuiTiEiEstrututaAntiga { get; set; }

    public int? BancaJornalId { get; set; }

    public int? FeiranteId { get; set; }

    [InverseProperty("AcaoSisvisa")]
    public virtual ICollection<AcaoSisvisaNaoConformidadePadronizadum> AcaoSisvisaNaoConformidadePadronizada { get; set; } = new List<AcaoSisvisaNaoConformidadePadronizadum>();

    [InverseProperty("AcaoSisvisa")]
    public virtual ICollection<AcaoSisvisaTarefa> AcaoSisvisaTarefas { get; set; } = new List<AcaoSisvisaTarefa>();

    [InverseProperty("AcaoSisvisa")]
    public virtual ICollection<AnexoAcaoSisvisa> AnexoAcaoSisvisas { get; set; } = new List<AnexoAcaoSisvisa>();

    [ForeignKey("ConfiguracaoProgramaColetaAmostrasProdutosId")]
    [InverseProperty("AcaoSisvisas")]
    public virtual ConfiguracaoProgramaColetaAmostrasProduto? ConfiguracaoProgramaColetaAmostrasProdutos { get; set; }

    [ForeignKey("CrecheId")]
    [InverseProperty("AcaoSisvisas")]
    public virtual Creche? Creche { get; set; }

    [InverseProperty("AcaoSisvisa")]
    public virtual ICollection<DespachoAcaoSisvisa> DespachoAcaoSisvisas { get; set; } = new List<DespachoAcaoSisvisa>();

    [InverseProperty("AcaoSisvisa")]
    public virtual ICollection<DocumentosAcaoSisvisa> DocumentosAcaoSisvisas { get; set; } = new List<DocumentosAcaoSisvisa>();

    [ForeignKey("EscolaMunicipalId")]
    [InverseProperty("AcaoSisvisas")]
    public virtual EscolaMunicipal? EscolaMunicipal { get; set; }

    [ForeignKey("EstabelecimentoId")]
    [InverseProperty("AcaoSisvisas")]
    public virtual Estabelecimento? Estabelecimento { get; set; }

    [ForeignKey("EstacaoTransportePublicoId")]
    [InverseProperty("AcaoSisvisas")]
    public virtual EstacaoTransportePublico? EstacaoTransportePublico { get; set; }

    [ForeignKey("FeiranteId")]
    [InverseProperty("AcaoSisvisas")]
    public virtual Feirante? Feirante { get; set; }

    [ForeignKey("HotelId")]
    [InverseProperty("AcaoSisvisas")]
    public virtual Hotel? Hotel { get; set; }

    [InverseProperty("AcaoSisvisa")]
    public virtual ICollection<Laudo> Laudos { get; set; } = new List<Laudo>();

    [ForeignKey("OutroLocalId")]
    [InverseProperty("AcaoSisvisas")]
    public virtual OutroLocal? OutroLocal { get; set; }

    [ForeignKey("PiscinaId")]
    [InverseProperty("AcaoSisvisas")]
    public virtual Piscina? Piscina { get; set; }

    [ForeignKey("PontoColetaVigiaguaId")]
    [InverseProperty("AcaoSisvisas")]
    public virtual PontoColetaVigiagua? PontoColetaVigiagua { get; set; }

    [ForeignKey("PrioridadeId")]
    [InverseProperty("AcaoSisvisas")]
    public virtual PrioridadeDaAcaoSisvisa Prioridade { get; set; } = null!;

    [ForeignKey("ProgramaId")]
    [InverseProperty("AcaoSisvisas")]
    public virtual Programa? Programa { get; set; }

    [ForeignKey("RequerenteId")]
    [InverseProperty("AcaoSisvisas")]
    public virtual Requerente? Requerente { get; set; }

    [ForeignKey("RequerimentoId")]
    [InverseProperty("AcaoSisvisas")]
    public virtual RequerimentoAutodeclaracao? Requerimento { get; set; }

    [ForeignKey("RequerimentoAdmId")]
    [InverseProperty("AcaoSisvisas")]
    public virtual RequerimentoAdministrativo? RequerimentoAdm { get; set; }

    [InverseProperty("AcaoSisvisa")]
    public virtual ICollection<Surto> Surtos { get; set; } = new List<Surto>();

    [ForeignKey("UnidadePublicaSaudeId")]
    [InverseProperty("AcaoSisvisas")]
    public virtual UnidadePublicaSaude? UnidadePublicaSaude { get; set; }
}
