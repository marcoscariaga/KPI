using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("HistoricoEstabelecimento")]
public partial class HistoricoEstabelecimento
{
    [Key]
    public int Id { get; set; }

    public int? InscricaoMunicipal { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? RazaoSocial { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NomeFantasia { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? CpfCnpj { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Logradouro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Complemento { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Bairro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Cidade { get; set; }

    [Column("UF")]
    [StringLength(2)]
    [Unicode(false)]
    public string? Uf { get; set; }

    public int? CepNumero { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SituacaoDoAlvara { get; set; }

    [Column("MEI")]
    public bool? Mei { get; set; }

    public short? CepComplemento { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? TipoLogradouro { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? CodigoLogradouro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Numero { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataInclusao { get; set; }

    public bool? Manha { get; set; }

    public bool? Tarde { get; set; }

    public bool? Noite { get; set; }

    public bool? Segunda { get; set; }

    public bool? Terca { get; set; }

    public bool? Quarta { get; set; }

    public bool? Quinta { get; set; }

    public bool? Sexta { get; set; }

    public bool? Sabado { get; set; }

    public bool? Domingo { get; set; }

    public bool? Feriados { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OutrosHorarios { get; set; }

    [Column(TypeName = "decimal(19, 5)")]
    public decimal? AreaOcupada { get; set; }

    public bool? FoiRequerente { get; set; }

    public bool? Supermercado { get; set; }
}
