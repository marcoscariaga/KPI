using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
public partial class VwEstabelecimentosPosTi
{
    public int Id { get; set; }

    public int InscricaoMunicipal { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string CpfCnpj { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? NomeFantasia { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? RazaoSocial { get; set; }

    [Column(TypeName = "decimal(19, 5)")]
    public decimal AreaOcupada { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string SituacaoDoAlvara { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Bairro { get; set; }

    public int CepNumero { get; set; }

    public int? RequerimentoId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCancelamento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDaInclusao { get; set; }

    [Column("FL_NOVO")]
    [StringLength(14)]
    [Unicode(false)]
    public string FlNovo { get; set; } = null!;

    public bool? TermoDeCienciaDaLegislacao { get; set; }

    public bool? TermoDeResponsabilidade { get; set; }

    public bool? TermoAceite { get; set; }

    public int SegmentoId { get; set; }

    public int TipoLicenca { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NumeroProcesso { get; set; }

    public bool? Mei { get; set; }

    public int? SituacaoDaEmissaoDaLicenca { get; set; }

    public int? Complexidade { get; set; }

    public int? Risco { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDaOndaParaLicenca { get; set; }
}
