using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("ProdutoTermoApreensao")]
public partial class ProdutoTermoApreensao
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Marca { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string NumeroRegistro { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DataFabricacao { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Validade { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LotePartida { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? TipoEmbalagem { get; set; }

    public int Quantidade { get; set; }

    public int UnidadeDeMedidaId { get; set; }

    public int TermoApreensaoId { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string RazaoSocialNomeFabricante { get; set; } = null!;

    [StringLength(14)]
    [Unicode(false)]
    public string CnpjFabricante { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string EnderecoFabricante { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? RazaoSocialNomeDetentorRegistro { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? CnpjDetentorRegistro { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? EnderecoDetentorRegistro { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? RazaoSocialNomeDistribuidor { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? CnpjDistribuidor { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? EnderecoDistribuidor { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? RazaoSocialNomeImportador { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? CnpjImportador { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? EnderecoImportador { get; set; }

    [ForeignKey("TermoApreensaoId")]
    [InverseProperty("ProdutoTermoApreensaos")]
    public virtual TermoApreensao TermoApreensao { get; set; } = null!;
}
