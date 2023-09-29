using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("HistoricoAtividadeFeirante")]
public partial class HistoricoAtividadeFeirante
{
    [Key]
    public int Id { get; set; }

    public int HistoricoFeiranteId { get; set; }

    public int AtividadeId { get; set; }

    [ForeignKey("AtividadeId")]
    [InverseProperty("HistoricoAtividadeFeirantes")]
    public virtual Atividade Atividade { get; set; } = null!;

    [ForeignKey("HistoricoFeiranteId")]
    [InverseProperty("HistoricoAtividadeFeirantes")]
    public virtual HistoricoFeirante HistoricoFeirante { get; set; } = null!;
}
