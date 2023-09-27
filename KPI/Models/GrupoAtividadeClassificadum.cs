using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Index("GrupoAtividadeId", "AtividadeId", Name = "UQ__GrupoAti__AE66512D2BE97B0D", IsUnique = true)]
public partial class GrupoAtividadeClassificadum
{
    public int GrupoAtividadeId { get; set; }

    public int AtividadeId { get; set; }

    [ForeignKey("AtividadeId")]
    public virtual Atividade Atividade { get; set; } = null!;

    [ForeignKey("GrupoAtividadeId")]
    public virtual GrupoAtividade GrupoAtividade { get; set; } = null!;
}
