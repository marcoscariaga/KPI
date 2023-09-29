using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("CapitulacoesLegaisDoNotificacaoInfracao")]
public partial class CapitulacoesLegaisDoNotificacaoInfracao
{
    public int NotificacaoInfracaoId { get; set; }

    public int CapitulacaoLegalId { get; set; }

    [ForeignKey("CapitulacaoLegalId")]
    public virtual CapitulacaoLegalInspecao CapitulacaoLegal { get; set; } = null!;

    [ForeignKey("NotificacaoInfracaoId")]
    public virtual NotificacaoInfracao NotificacaoInfracao { get; set; } = null!;
}
