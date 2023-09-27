using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("HistoricoAtividadeAmbulante")]
public partial class HistoricoAtividadeAmbulante
{
    [Key]
    public int Id { get; set; }

    public int HistoricoAmbulanteId { get; set; }

    public int AtividadeId { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string Codigo { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    [ForeignKey("AtividadeId")]
    [InverseProperty("HistoricoAtividadeAmbulantes")]
    public virtual Atividade Atividade { get; set; } = null!;

    [ForeignKey("HistoricoAmbulanteId")]
    [InverseProperty("HistoricoAtividadeAmbulantes")]
    public virtual HistoricoAmbulante HistoricoAmbulante { get; set; } = null!;
}
