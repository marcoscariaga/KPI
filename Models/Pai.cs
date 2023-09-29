using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

public partial class Pai
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string NomePais { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Sigla2 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Sigla3 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string CodigoPais { get; set; } = null!;

    [InverseProperty("PaisOrigem")]
    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
