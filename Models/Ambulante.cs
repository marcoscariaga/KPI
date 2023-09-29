using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Ambulante")]
[Index("InscricaoMunicipal", Name = "UQ__Ambulant__DC2FA3BF79F2F81D", IsUnique = true)]
public partial class Ambulante
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string InscricaoMunicipal { get; set; } = null!;

    public int AutorizacaoId { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string CpfCnpj { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? EmailTitular { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TelefoneTitular { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CelularTitular { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NomeTitular { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SituacaoDoAlvara { get; set; } = null!;

    [StringLength(6)]
    [Unicode(false)]
    public string? CodigoLogradouro { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? Logradouro { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Numero { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Complemento { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Bairro { get; set; }

    [Column("CEP")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Cep { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? CodigoLogradouroPonto { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? LogradouroPonto { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ReferenciaPonto { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NumeroPonto { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ComplementoPonto { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BairroPonto { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Equipamento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataInclusao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataAlteracao { get; set; }

    public int? SegmentoId { get; set; }

    public int? RequerimentoId { get; set; }

    public int? Complexidade { get; set; }

    public int? Risco { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? AreaUtil { get; set; }

    public bool TermoDeCienciaDaLegislacao { get; set; }

    public bool TermoDeResponsabilidade { get; set; }

    public bool Mei { get; set; }

    public bool PequenosAgricultores { get; set; }

    public bool AgricultoresFamiliares { get; set; }

    public bool ProdutoresAgroecologicos { get; set; }

    public bool ProdutoresQuilombolas { get; set; }

    public int? SituacaoDaLicencaSanitaria { get; set; }

    public int? SituacaoDaEmissaoDaLicenca { get; set; }

    public int? TipoLicenca { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NumeroLicenca { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NumeroDeAutenticacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCriacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataValidade { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NumeroProcesso { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataRevogacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCancelamento { get; set; }

    public int? JustificativaId { get; set; }

    public int? SituacaoValidacaoDaLicencaSanitaria { get; set; }

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

    [StringLength(255)]
    [Unicode(false)]
    public string? OutrosHorarios { get; set; }

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

    [InverseProperty("Ambulante")]
    public virtual ICollection<AtividadeAmbulante> AtividadeAmbulantes { get; set; } = new List<AtividadeAmbulante>();

    [InverseProperty("Ambulante")]
    public virtual ICollection<EventoAmbulante> EventoAmbulantes { get; set; } = new List<EventoAmbulante>();

    [InverseProperty("Ambulante")]
    public virtual ICollection<HistoricoAmbulante> HistoricoAmbulantes { get; set; } = new List<HistoricoAmbulante>();

    [ForeignKey("JustificativaId")]
    [InverseProperty("Ambulantes")]
    public virtual Justificativa? Justificativa { get; set; }

    [InverseProperty("Ambulante")]
    public virtual ICollection<LicencaCanceladaPorRequerente> LicencaCanceladaPorRequerentes { get; set; } = new List<LicencaCanceladaPorRequerente>();

    [ForeignKey("RequerimentoId")]
    [InverseProperty("Ambulantes")]
    public virtual RequerimentoAutodeclaracao? Requerimento { get; set; }

    [InverseProperty("Ambulante")]
    public virtual ICollection<RequerimentoAutodeclaracao> RequerimentoAutodeclaracaos { get; set; } = new List<RequerimentoAutodeclaracao>();
}
