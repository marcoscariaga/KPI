using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Setor")]
[Index("Codigo", Name = "UQ__Setor__06370DAC0F824689", IsUnique = true)]
public partial class Setor
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Codigo { get; set; } = null!;

    [StringLength(512)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;
}
