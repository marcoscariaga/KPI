using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("RespostasDoVeiculoParaInspecao")]
public partial class RespostasDoVeiculoParaInspecao
{
    public int DemandaAcaoSisvisaId { get; set; }

    public int Ordem { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Assunto { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Enunciado { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Valor { get; set; }

    public int TipoParecerId { get; set; }

    public int SegmentoId { get; set; }

    public int PerguntaId { get; set; }

    public int VeiculoId { get; set; }

    [ForeignKey("DemandaAcaoSisvisaId")]
    public virtual AcaoSisvisa DemandaAcaoSisvisa { get; set; } = null!;

    [ForeignKey("PerguntaId")]
    public virtual Perguntum Pergunta { get; set; } = null!;

    [ForeignKey("VeiculoId")]
    public virtual Veiculo Veiculo { get; set; } = null!;
}
