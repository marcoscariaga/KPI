using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("AtividadeSecundariaUnidadePublica")]
public partial class AtividadeSecundariaUnidadePublica
{
    public int UnidadePublicaSaudeId { get; set; }

    public int AtividadeSecundariaId { get; set; }

    [ForeignKey("AtividadeSecundariaId")]
    public virtual AtividadeSecundarium AtividadeSecundaria { get; set; } = null!;

    [ForeignKey("UnidadePublicaSaudeId")]
    public virtual UnidadePublicaSaude UnidadePublicaSaude { get; set; } = null!;
}
