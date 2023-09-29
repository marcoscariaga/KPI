using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("ServidorAtividade")]
public partial class ServidorAtividade
{
    public int ServidorId { get; set; }

    public int AtividadeId { get; set; }

    [ForeignKey("AtividadeId")]
    public virtual Atividade Atividade { get; set; } = null!;

    [ForeignKey("ServidorId")]
    public virtual Servidor Servidor { get; set; } = null!;
}
