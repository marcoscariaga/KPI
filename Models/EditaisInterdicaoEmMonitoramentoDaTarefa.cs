using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("EditaisInterdicaoEmMonitoramentoDaTarefa")]
public partial class EditaisInterdicaoEmMonitoramentoDaTarefa
{
    public int TarefaId { get; set; }

    public int EditalInterdicaoId { get; set; }

    [ForeignKey("EditalInterdicaoId")]
    public virtual EditalInterdicao EditalInterdicao { get; set; } = null!;

    [ForeignKey("TarefaId")]
    public virtual Tarefa Tarefa { get; set; } = null!;
}
