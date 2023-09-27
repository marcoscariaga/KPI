using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("AtividadesDaAutorizacao")]
public partial class AtividadesDaAutorizacao
{
    public int AutorizacaoSanitariaId { get; set; }

    public int AtividadeId { get; set; }

    [ForeignKey("AtividadeId")]
    public virtual Atividade Atividade { get; set; } = null!;

    [ForeignKey("AutorizacaoSanitariaId")]
    public virtual AutorizacaoSanitarium AutorizacaoSanitaria { get; set; } = null!;
}
