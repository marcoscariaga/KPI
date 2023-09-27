using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("AtividadeAmbulante")]
[Index("AmbulanteId", "AtividadeId", Name = "UC_AmbulanteAtividade", IsUnique = true)]
public partial class AtividadeAmbulante
{
    [Key]
    public int Id { get; set; }

    public int AmbulanteId { get; set; }

    public int AtividadeId { get; set; }

    [ForeignKey("AmbulanteId")]
    [InverseProperty("AtividadeAmbulantes")]
    public virtual Ambulante Ambulante { get; set; } = null!;

    [ForeignKey("AtividadeId")]
    [InverseProperty("AtividadeAmbulantes")]
    public virtual Atividade Atividade { get; set; } = null!;
}
