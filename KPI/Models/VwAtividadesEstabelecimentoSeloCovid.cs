using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
public partial class VwAtividadesEstabelecimentoSeloCovid
{
    [StringLength(14)]
    [Unicode(false)]
    public string CpfCnpj { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? RazaoSocial { get; set; }

    public int InscricaoMunicipal { get; set; }

    public int? RequerimentoId { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? Codigo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Descricao { get; set; }

    public bool? Licenciada { get; set; }
}
