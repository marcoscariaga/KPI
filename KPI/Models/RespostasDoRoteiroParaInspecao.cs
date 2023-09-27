using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("RespostasDoRoteiroParaInspecao")]
[Index("DemandaAcaoSisvisaId", Name = "gqs_respostarot")]
public partial class RespostasDoRoteiroParaInspecao
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

    [StringLength(200)]
    [Unicode(false)]
    public string? ValorArquivo { get; set; }

    public int TipoParecerId { get; set; }

    public int SegmentoId { get; set; }

    public int? PerguntaId { get; set; }

    public int? PerguntaProgramaId { get; set; }

    [ForeignKey("DemandaAcaoSisvisaId")]
    public virtual AcaoSisvisa DemandaAcaoSisvisa { get; set; } = null!;

    [ForeignKey("PerguntaId")]
    public virtual Perguntum? Pergunta { get; set; }

    [ForeignKey("PerguntaProgramaId")]
    public virtual PerguntaPrograma? PerguntaPrograma { get; set; }
}
