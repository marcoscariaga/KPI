﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Piscina")]
[Index("Cnpj", Name = "UQ__Piscina__A299CC9229971E47", IsUnique = true)]
public partial class Piscina
{
    [Key]
    public int Id { get; set; }

    public int TipoPublicoAlvoId { get; set; }

    public int TipoLocaldaPiscinaId { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? Cnpj { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string RazaoSocial { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string NomeDeContato { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string TelefoneDeContato { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? Telefone2 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataDaInclusao { get; set; }

    [Column(TypeName = "decimal(9, 7)")]
    public decimal Latitude { get; set; }

    [Column(TypeName = "decimal(9, 7)")]
    public decimal Longitude { get; set; }

    public int SegmentoId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Ra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BairroDaLocalizacao { get; set; }

    public bool PreenchidoPeloServico { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Logradouro { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string? TipoLogradouro { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? CodigoLogradouro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Numero { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Complemento { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Bairro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Cidade { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Uf { get; set; } = null!;

    public int CepNumero { get; set; }

    public short CepComplemento { get; set; }

    [InverseProperty("Piscina")]
    public virtual ICollection<AcaoSisvisa> AcaoSisvisas { get; set; } = new List<AcaoSisvisa>();

    [InverseProperty("Piscina")]
    public virtual ICollection<HistoricoInspecao> HistoricoInspecaos { get; set; } = new List<HistoricoInspecao>();
}
