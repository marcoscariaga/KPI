using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Feirante")]
[Index("InscricaoMunicipal", Name = "UQ__Feirante__DC2FA3BF485B9C89", IsUnique = true)]
public partial class Feirante
{
    [Key]
    public int Id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string InscricaoMunicipal { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string TipoPessoa { get; set; } = null!;

    [StringLength(14)]
    [Unicode(false)]
    public string? CpfCnpj { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Telefone { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Telefone2 { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string RazaoSocial { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? SituacaoDoAlvara { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string CodigoTipoFeira { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string DescricaoTipoFeira { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string CodigoAtividade { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string CodigoCategoria { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string DescricaoCategoria { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string CodigoEquipamento { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string DescricaoEquipamento { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DataInclusao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataAlteracao { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Logradouro { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? NumeroPorta { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Complemento { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Bairro { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Cep { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Municipio { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Uf { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Email { get; set; }

    public int? SegmentoId { get; set; }

    public int? RequerimentoId { get; set; }

    public int? Complexidade { get; set; }

    public int? Risco { get; set; }

    [StringLength(10)]
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

    [StringLength(1)]
    [Unicode(false)]
    public string? Afastado { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Invalido { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsentoTuap { get; set; }

    public int? SituacaoValidacaoDaLicencaSanitaria { get; set; }

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

    [InverseProperty("Feirante")]
    public virtual ICollection<AcaoSisvisa> AcaoSisvisas { get; set; } = new List<AcaoSisvisa>();

    [InverseProperty("Feirante")]
    public virtual ICollection<AtividadeFeirante> AtividadeFeirantes { get; set; } = new List<AtividadeFeirante>();

    [InverseProperty("Feirante")]
    public virtual ICollection<EventoFeirante> EventoFeirantes { get; set; } = new List<EventoFeirante>();

    [InverseProperty("Feirante")]
    public virtual ICollection<FeiranteFeira> FeiranteFeiras { get; set; } = new List<FeiranteFeira>();

    [InverseProperty("Feirante")]
    public virtual ICollection<HistoricoFeirante> HistoricoFeirantes { get; set; } = new List<HistoricoFeirante>();

    [ForeignKey("JustificativaId")]
    [InverseProperty("Feirantes")]
    public virtual Justificativa? Justificativa { get; set; }

    [ForeignKey("RequerimentoId")]
    [InverseProperty("Feirantes")]
    public virtual RequerimentoAutodeclaracao? Requerimento { get; set; }

    [InverseProperty("Feirante")]
    public virtual ICollection<RequerimentoAutodeclaracao> RequerimentoAutodeclaracaos { get; set; } = new List<RequerimentoAutodeclaracao>();
}
