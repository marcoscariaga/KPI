using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("HistoricoAtividadesDoEstabelecimento")]
public partial class HistoricoAtividadesDoEstabelecimento
{
    public int HistoricoEstabelecimentoId { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? Codigo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Descricao { get; set; }

    public bool? Licenciada { get; set; }

    public bool NecessitaComplemento { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Complemento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataInclusao { get; set; }
}
