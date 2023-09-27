using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
public partial class AtividadesDoTermoVisitaSanitarium
{
    public int TermoVisitaSanitariaId { get; set; }

    public int AtividadeId { get; set; }

    [ForeignKey("AtividadeId")]
    public virtual Atividade Atividade { get; set; } = null!;

    [ForeignKey("TermoVisitaSanitariaId")]
    public virtual TermoVisitaSanitarium TermoVisitaSanitaria { get; set; } = null!;
}
