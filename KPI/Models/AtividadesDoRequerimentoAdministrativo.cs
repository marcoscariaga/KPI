using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("AtividadesDoRequerimentoAdministrativo")]
[Index("AtividadeId", Name = "IX_AtividadesDoRequerimentoAdministrativo_AtividadeId")]
[Index("RequerimentoAdministrativoId", Name = "IX_AtividadesDoRequerimentoAdministrativo_RequerimentoAdministrativoId")]
public partial class AtividadesDoRequerimentoAdministrativo
{
    public int RequerimentoAdministrativoId { get; set; }

    public int AtividadeId { get; set; }

    [ForeignKey("AtividadeId")]
    public virtual Atividade Atividade { get; set; } = null!;

    [ForeignKey("RequerimentoAdministrativoId")]
    public virtual RequerimentoAdministrativo RequerimentoAdministrativo { get; set; } = null!;
}
