using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Index("Descricao", Name = "UQ__Atividad__008BA9EF113584D1", IsUnique = true)]
public partial class AtividadeSecundarium
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    public int AtividadeId { get; set; }

    [ForeignKey("AtividadeId")]
    [InverseProperty("AtividadeSecundaria")]
    public virtual Atividade Atividade { get; set; } = null!;

    [InverseProperty("AtividadeSecundaria")]
    public virtual ICollection<Programa> Programas { get; set; } = new List<Programa>();
}
