using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("CapitulacoesLegaisDoTermoIntimacao")]
public partial class CapitulacoesLegaisDoTermoIntimacao
{
    public int TermoIntimacaoId { get; set; }

    public int CapitulacaoLegalId { get; set; }

    [ForeignKey("CapitulacaoLegalId")]
    public virtual CapitulacaoLegalInspecao CapitulacaoLegal { get; set; } = null!;

    [ForeignKey("TermoIntimacaoId")]
    public virtual TermoIntimacao TermoIntimacao { get; set; } = null!;
}
