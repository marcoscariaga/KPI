using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("TermosIntimacaoEmMonitoramentoDaTarefa")]
public partial class TermosIntimacaoEmMonitoramentoDaTarefa
{
    public int TarefaId { get; set; }

    public int TermoIntimacaoId { get; set; }

    [ForeignKey("TarefaId")]
    public virtual Tarefa Tarefa { get; set; } = null!;

    [ForeignKey("TermoIntimacaoId")]
    public virtual TermoIntimacao TermoIntimacao { get; set; } = null!;
}
