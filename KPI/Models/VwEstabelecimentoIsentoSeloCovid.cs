using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
public partial class VwEstabelecimentoIsentoSeloCovid
{
    [StringLength(14)]
    [Unicode(false)]
    public string CpfCnpj { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? RazaoSocial { get; set; }

    public int InscricaoMunicipal { get; set; }

    public int? SituacaoDaEmissaoDaLicenca { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataValidade { get; set; }

    public bool? Mei { get; set; }

    public int? RequerimentoId { get; set; }
}
