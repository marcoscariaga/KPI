using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Cargo")]
[Index("Descricao", Name = "UQ__Cargo__008BA9EF5A3A55A2", IsUnique = true)]
public partial class Cargo
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    public string? Atribuicoes { get; set; }

    public bool RealizaInspecao { get; set; }

    [InverseProperty("Cargo")]
    public virtual ICollection<Servidor> Servidors { get; set; } = new List<Servidor>();
}
