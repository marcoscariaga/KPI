using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("NaoConformidadesDoTermoIntimacao")]
[Index("TermoIntimacaoId", Name = "gqs_carga_3")]
public partial class NaoConformidadesDoTermoIntimacao
{
    public int TermoIntimacaoId { get; set; }

    public int NaoConformidadeId { get; set; }

    public string? DetalhamentoOcorrencia { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MatriculaAtualizacao { get; set; }

    [ForeignKey("NaoConformidadeId")]
    public virtual NaoConformidadePadronizadum NaoConformidade { get; set; } = null!;

    [ForeignKey("TermoIntimacaoId")]
    public virtual TermoIntimacao TermoIntimacao { get; set; } = null!;
}
