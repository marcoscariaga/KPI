using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("AcaoSisvisaTarefa")]
[Index("TarefaId", Name = "gqs_acaoSisvisaTarefa")]
public partial class AcaoSisvisaTarefa
{
    [Key]
    public int Id { get; set; }

    public int TarefaId { get; set; }

    public int AcaoSisvisaId { get; set; }

    public bool DeMonitoramentoTiOuEi { get; set; }

    [ForeignKey("AcaoSisvisaId")]
    [InverseProperty("AcaoSisvisaTarefas")]
    public virtual AcaoSisvisa AcaoSisvisa { get; set; } = null!;

    [ForeignKey("TarefaId")]
    [InverseProperty("AcaoSisvisaTarefas")]
    public virtual Tarefa Tarefa { get; set; } = null!;
}
