using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("BancaJornalProdutoBancaJornal")]
[Index("IdProdutoBancaJornal", "IdBancaJornal", Name = "UC_Person", IsUnique = true)]
public partial class BancaJornalProdutoBancaJornal
{
    [Key]
    public int Id { get; set; }

    public int IdProdutoBancaJornal { get; set; }

    public int IdBancaJornal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataInclusao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataAlteracao { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? UsuarioAlteracao { get; set; }

    [ForeignKey("IdBancaJornal")]
    [InverseProperty("BancaJornalProdutoBancaJornals")]
    public virtual BancaJornal IdBancaJornalNavigation { get; set; } = null!;

    [ForeignKey("IdProdutoBancaJornal")]
    [InverseProperty("BancaJornalProdutoBancaJornals")]
    public virtual ProdutoBancaJornal IdProdutoBancaJornalNavigation { get; set; } = null!;
}
