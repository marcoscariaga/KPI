using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("AtividadeFeirante")]
public partial class AtividadeFeirante
{
    [Key]
    public int Id { get; set; }

    public int AtividadeId { get; set; }

    public int FeiranteId { get; set; }

    [ForeignKey("AtividadeId")]
    [InverseProperty("AtividadeFeirantes")]
    public virtual Atividade Atividade { get; set; } = null!;

    [ForeignKey("FeiranteId")]
    [InverseProperty("AtividadeFeirantes")]
    public virtual Feirante Feirante { get; set; } = null!;
}
