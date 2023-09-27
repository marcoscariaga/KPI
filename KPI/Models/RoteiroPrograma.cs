using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("RoteiroPrograma")]
[Index("Nome", Name = "UQ__RoteiroP__7D8FE3B20618D7E0", IsUnique = true)]
public partial class RoteiroPrograma
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    [InverseProperty("RoteiroPrograma")]
    public virtual ICollection<Programa> Programas { get; set; } = new List<Programa>();
}
