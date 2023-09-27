using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("GrupoAtividade")]
[Index("Descricao", Name = "UQ__GrupoAti__008BA9EF2818EA29", IsUnique = true)]
public partial class GrupoAtividade
{
    [Key]
    public int Id { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    public bool RelatorioGerencial { get; set; }

    public bool QualificaServidor { get; set; }

    [InverseProperty("GrupoAtividade")]
    public virtual ICollection<Programa> Programas { get; set; } = new List<Programa>();
}
