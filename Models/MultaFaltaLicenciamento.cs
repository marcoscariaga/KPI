using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("MultaFaltaLicenciamento")]
public partial class MultaFaltaLicenciamento
{
    [Key]
    public int Id { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string InformacaoComplementar { get; set; } = null!;

    [StringLength(60)]
    [Unicode(false)]
    public string NomeSecretaria { get; set; } = null!;

    [StringLength(60)]
    [Unicode(false)]
    public string OrgaoAtuante { get; set; } = null!;

    [StringLength(14)]
    [Unicode(false)]
    public string CpfCnpj { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string MatriculaAtuante { get; set; } = null!;

    [StringLength(60)]
    [Unicode(false)]
    public string NomeAtuante { get; set; } = null!;

    public int NumeroAuto { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string InscricaoRequerente { get; set; } = null!;

    [StringLength(60)]
    [Unicode(false)]
    public string NomeRequerente { get; set; } = null!;

    [StringLength(14)]
    [Unicode(false)]
    public string DocumentoRequerente { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Endereco { get; set; } = null!;

    [StringLength(6)]
    [Unicode(false)]
    public string? NumeroEndereco { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string EnderecoComplemento { get; set; } = null!;

    [Column("enderecoComplementoSuplementar")]
    [StringLength(20)]
    [Unicode(false)]
    public string EnderecoComplementoSuplementar { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string Bairro { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Municipio { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string Cep { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Uf { get; set; } = null!;

    [StringLength(220)]
    [Unicode(false)]
    public string CapitulacaoLegal { get; set; } = null!;

    [StringLength(220)]
    [Unicode(false)]
    public string AutoInfracao { get; set; } = null!;

    [StringLength(220)]
    [Unicode(false)]
    public string PenalidadeInfracao { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataInfracao { get; set; }

    [StringLength(70)]
    [Unicode(false)]
    public string LocalInfracao { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataLavraturaInfracao { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string MoedaMonetaria { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string NumeroProcesso { get; set; } = null!;

    public int Orgao { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CodigoDoLogradouro { get; set; }
}
