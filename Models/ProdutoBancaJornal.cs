using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("ProdutoBancaJornal")]
public partial class ProdutoBancaJornal
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    public int? SegmentoId { get; set; }

    public int Complexidade { get; set; }

    public int Risco { get; set; }

    public bool Ativo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataCadastro { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataAtualizacao { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? UsuarioAlteracao { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MotivoAlteracao { get; set; }

    public int? TipoDeLicenciamentoId { get; set; }

    public bool? ExigeResponsavelTecnico { get; set; }

    [InverseProperty("IdProdutoBancaJornalNavigation")]
    public virtual ICollection<BancaJornalProdutoBancaJornal> BancaJornalProdutoBancaJornals { get; set; } = new List<BancaJornalProdutoBancaJornal>();

    [ForeignKey("TipoDeLicenciamentoId")]
    [InverseProperty("ProdutoBancaJornals")]
    public virtual TipoDeLicenciamento? TipoDeLicenciamento { get; set; }
}
