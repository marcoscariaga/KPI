using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("smf_estabelecimento")]
public partial class SmfEstabelecimento
{
    [Column("INSCRICAOMUNICIPAL_ORIG", TypeName = "numeric(8, 0)")]
    public decimal? InscricaomunicipalOrig { get; set; }

    [Column("INSCRICAOMUNICIPAL")]
    [StringLength(8)]
    [Unicode(false)]
    public string? Inscricaomunicipal { get; set; }

    [Column("NOME")]
    [StringLength(81)]
    [Unicode(false)]
    public string? Nome { get; set; }

    [Column("TIPOCPFCNPJ")]
    [StringLength(4)]
    [Unicode(false)]
    public string? Tipocpfcnpj { get; set; }

    [Column("CPFCNPJ")]
    [StringLength(14)]
    [Unicode(false)]
    public string? Cpfcnpj { get; set; }

    [Column("NOMEFANTASIA")]
    [StringLength(35)]
    [Unicode(false)]
    public string? Nomefantasia { get; set; }

    [Column("CODIGOSTATUS")]
    [StringLength(2)]
    [Unicode(false)]
    public string? Codigostatus { get; set; }

    [Column("DESCRICAOSTATUS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Descricaostatus { get; set; }

    [Column("VIGILANCIASANITARIA_AREA", TypeName = "numeric(8, 2)")]
    public decimal? VigilanciasanitariaArea { get; set; }

    [Column("CODIGOLOGRADOUROESTABELECIMENTO")]
    [StringLength(6)]
    [Unicode(false)]
    public string? Codigologradouroestabelecimento { get; set; }

    [Column("TIPOLOGRADOUROESTABELECIMENTO")]
    [StringLength(3)]
    [Unicode(false)]
    public string? Tipologradouroestabelecimento { get; set; }

    [Column("NOMELOGRADOUROESTABELECIMENTO")]
    [StringLength(46)]
    [Unicode(false)]
    public string? Nomelogradouroestabelecimento { get; set; }

    [Column("NUMEROPORTAESTABELECIMENTO")]
    [StringLength(5)]
    [Unicode(false)]
    public string? Numeroportaestabelecimento { get; set; }

    [Column("COMPLEMENTOESTABELECIMENTO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Complementoestabelecimento { get; set; }

    [Column("NOMEBAIRROESTABELECIMENTO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Nomebairroestabelecimento { get; set; }

    [Column("CIDADEESTABELECIMENTO")]
    [StringLength(14)]
    [Unicode(false)]
    public string? Cidadeestabelecimento { get; set; }

    [Column("UNIDADEFEDERATIVAESTABELECIMENTO")]
    [StringLength(2)]
    [Unicode(false)]
    public string? Unidadefederativaestabelecimento { get; set; }

    [Column("CEPESTABELECIMENTO")]
    [StringLength(8)]
    [Unicode(false)]
    public string? Cepestabelecimento { get; set; }

    [Column("INSCRICAO")]
    public int? Inscricao { get; set; }
}
