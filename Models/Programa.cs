using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Programa")]
public partial class Programa
{
    [Key]
    public int Id { get; set; }

    public int TipoProgramaId { get; set; }

    public int SegmentoId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Sigla { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Objetivo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataInicio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataFim { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? DocumentoAnexado { get; set; }

    public int SituacaoId { get; set; }

    public string? ObservacaoInterna { get; set; }

    public int? LaboratorioId { get; set; }

    public int? JustificativaId { get; set; }

    public int TipoPublicoAlvoId { get; set; }

    public int TipoRequerimentoId { get; set; }

    [Column("CVSId")]
    public int Cvsid { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Bairro { get; set; }

    public int? QuantidadeAmostrasMes { get; set; }

    public int? GrupoAtividadeId { get; set; }

    public int? AtividadeId { get; set; }

    public int? AtividadeSecundariaId { get; set; }

    public int? RoteiroProgramaId { get; set; }

    public int? RoteiroLicenciamentoId { get; set; }

    [InverseProperty("Programa")]
    public virtual ICollection<AcaoSisvisa> AcaoSisvisas { get; set; } = new List<AcaoSisvisa>();

    [ForeignKey("AtividadeId")]
    [InverseProperty("Programas")]
    public virtual Atividade? Atividade { get; set; }

    [ForeignKey("AtividadeSecundariaId")]
    [InverseProperty("Programas")]
    public virtual AtividadeSecundarium? AtividadeSecundaria { get; set; }

    [InverseProperty("Programa")]
    public virtual ICollection<ConfiguracaoProgramaColetaAmostrasProduto> ConfiguracaoProgramaColetaAmostrasProdutos { get; set; } = new List<ConfiguracaoProgramaColetaAmostrasProduto>();

    [ForeignKey("GrupoAtividadeId")]
    [InverseProperty("Programas")]
    public virtual GrupoAtividade? GrupoAtividade { get; set; }

    [ForeignKey("JustificativaId")]
    [InverseProperty("Programas")]
    public virtual Justificativa? Justificativa { get; set; }

    [ForeignKey("LaboratorioId")]
    [InverseProperty("Programas")]
    public virtual Laboratorio? Laboratorio { get; set; }

    [ForeignKey("RoteiroLicenciamentoId")]
    [InverseProperty("Programas")]
    public virtual Roteiro? RoteiroLicenciamento { get; set; }

    [ForeignKey("RoteiroProgramaId")]
    [InverseProperty("Programas")]
    public virtual RoteiroPrograma? RoteiroPrograma { get; set; }
}
