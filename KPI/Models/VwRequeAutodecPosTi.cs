using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
public partial class VwRequeAutodecPosTi
{
    public int Id { get; set; }

    public int EstabelecimentoId { get; set; }

    public int? JustificativaId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataInicio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataLimiteParaEnvio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataFim { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDeEnvio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataInicioAnalise { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataExigencia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataLimiteParaCumprimentoExigencia { get; set; }

    public int DiasParaTerminoDaAnalise { get; set; }

    public int TipoId { get; set; }

    public int LicenciamentoId { get; set; }

    public int SituacaoId { get; set; }

    public long Cpf { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    public string? ObservacaoInterna { get; set; }

    public string? Observacao { get; set; }

    [Column("ehResidencia")]
    public bool? EhResidencia { get; set; }

    public bool? EhSimplesEscritorio { get; set; }

    public bool? TemFuncionamentoNoLocal { get; set; }

    public bool? TemInternacao { get; set; }
}
