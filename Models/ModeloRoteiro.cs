using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("ModeloRoteiro")]
[Index("Nome", Name = "UQ__ModeloRo__7D8FE3B227F8EE98", IsUnique = true)]
public partial class ModeloRoteiro
{
    /// <summary>
    /// Chave primária
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Nome
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    /// <summary>
    /// 1-Comum  2-Alimento  3-Engenharia  4-Saúde  5-Zoonose
    /// </summary>
    public int SegmentoId { get; set; }

    [InverseProperty("Modelo")]
    public virtual ICollection<Roteiro> Roteiros { get; set; } = new List<Roteiro>();
}
