using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("CapitulacoesLegaisDoEditalInterdicao")]
public partial class CapitulacoesLegaisDoEditalInterdicao
{
    public int EditalInterdicaoId { get; set; }

    public int CapitulacaoLegalId { get; set; }

    [ForeignKey("CapitulacaoLegalId")]
    public virtual CapitulacaoLegalInspecao CapitulacaoLegal { get; set; } = null!;

    [ForeignKey("EditalInterdicaoId")]
    public virtual EditalInterdicao EditalInterdicao { get; set; } = null!;
}
