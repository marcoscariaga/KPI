using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Produto")]
public partial class Produto
{
    [Key]
    public int Id { get; set; }

    [StringLength(124)]
    [Unicode(false)]
    public string? NomeFabricanteOrigem { get; set; }

    [StringLength(124)]
    [Unicode(false)]
    public string NomeProduto { get; set; } = null!;

    public int SituacaoCadastroId { get; set; }

    public int TipoComunicadoId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataComunicado { get; set; }

    [StringLength(124)]
    [Unicode(false)]
    public string Marca { get; set; } = null!;

    public int UnidadeTempoValidadeId { get; set; }

    public int TempoValidade { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? NomeArquivoAnexoRotulo { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? NomeArquivoAnexoFichaTecnica { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string DescricaoEmbalagem { get; set; } = null!;

    public int? RequerenteId { get; set; }

    public int EstabelecimentoId { get; set; }

    public int RequerimentoAdmId { get; set; }

    public int CategoriaProdutoId { get; set; }

    public int? PaisOrigemId { get; set; }

    public int? JustificativaId { get; set; }

    public bool Municipal { get; set; }

    public bool Estadual { get; set; }

    public bool Nacional { get; set; }

    public bool Exportacao { get; set; }

    [ForeignKey("CategoriaProdutoId")]
    [InverseProperty("Produtos")]
    public virtual CategoriaProduto CategoriaProduto { get; set; } = null!;

    [ForeignKey("EstabelecimentoId")]
    [InverseProperty("Produtos")]
    public virtual Estabelecimento Estabelecimento { get; set; } = null!;

    [ForeignKey("JustificativaId")]
    [InverseProperty("Produtos")]
    public virtual Justificativa? Justificativa { get; set; }

    [ForeignKey("PaisOrigemId")]
    [InverseProperty("Produtos")]
    public virtual Pai? PaisOrigem { get; set; }

    [ForeignKey("RequerenteId")]
    [InverseProperty("Produtos")]
    public virtual Requerente? Requerente { get; set; }

    [ForeignKey("RequerimentoAdmId")]
    [InverseProperty("Produtos")]
    public virtual RequerimentoAdministrativo RequerimentoAdm { get; set; } = null!;
}
