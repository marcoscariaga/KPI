using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
public partial class VwEstabelecimentoDeliveryCarioca
{
    public int? RequerimentoId { get; set; }

    public int Id { get; set; }

    public int InscricaoMunicipal { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string CpfCnpj { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? RazaoSocial { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? TipoLogradouro { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Logradouro { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Numero { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Complemento { get; set; }

    public int CepNumero { get; set; }

    public short CepComplemento { get; set; }

    public int? SituacaoDaEmissaoDaLicenca { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataValidade { get; set; }

    public bool? Mei { get; set; }
}
