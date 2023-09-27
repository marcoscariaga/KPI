using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("CategoriaProduto")]
[Index("Codigo", Name = "UQ__Categori__06370DAC536D5C82", IsUnique = true)]
public partial class CategoriaProduto
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Codigo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    public bool ExigeRegistro { get; set; }

    public int? Ativo { get; set; }

    [InverseProperty("CategoriaProduto")]
    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
