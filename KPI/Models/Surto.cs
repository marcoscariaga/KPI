using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Surto")]
public partial class Surto
{
    [Key]
    public int Id { get; set; }

    public int? TipoDeInstalacaoId { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? NomeReclamante { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? NomeReclamado { get; set; }

    public int? NumeroDeAcometidos { get; set; }

    [Column("SinaisESintomas")]
    public string? SinaisEsintomas { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PeriodoDeIncubacao { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? AgenteEtiologicoSuspeito { get; set; }

    public string? AlimentosColetados { get; set; }

    public string? ResultadoDaAnalise { get; set; }

    public string? ConclusaoDoSurto { get; set; }

    public string? Observacoes { get; set; }

    public int AcaoSisvisaId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LogradouroReclamante { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? TipoLogradouroReclamante { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? CodigoLogradouroReclamante { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NumeroReclamante { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ComplementoReclamante { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BairroReclamante { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CidadeReclamante { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? UfReclamante { get; set; }

    public int? CepNumeroReclamante { get; set; }

    public short? CepComplementoReclamante { get; set; }

    [ForeignKey("AcaoSisvisaId")]
    [InverseProperty("Surtos")]
    public virtual AcaoSisvisa AcaoSisvisa { get; set; } = null!;
}
