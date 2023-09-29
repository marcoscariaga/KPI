using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("AtividadesSecundariasDoEstabelecimento")]
public partial class AtividadesSecundariasDoEstabelecimento
{
    public int EstabelecimentoId { get; set; }

    public int AtividadeSecundariaId { get; set; }

    [ForeignKey("AtividadeSecundariaId")]
    public virtual AtividadeSecundarium AtividadeSecundaria { get; set; } = null!;

    [ForeignKey("EstabelecimentoId")]
    public virtual Estabelecimento Estabelecimento { get; set; } = null!;
}
