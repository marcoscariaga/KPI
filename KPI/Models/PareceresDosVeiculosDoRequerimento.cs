using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("PareceresDosVeiculosDoRequerimento")]
public partial class PareceresDosVeiculosDoRequerimento
{
    public int RequerimentoId { get; set; }

    public int Ordem { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Matricula { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? Observacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Data { get; set; }

    public int TipoParecerId { get; set; }

    public int PerguntaId { get; set; }

    public int VeiculoId { get; set; }

    [ForeignKey("PerguntaId")]
    public virtual Perguntum Pergunta { get; set; } = null!;

    [ForeignKey("RequerimentoId")]
    public virtual RequerimentoAutodeclaracao Requerimento { get; set; } = null!;

    [ForeignKey("VeiculoId")]
    public virtual Veiculo Veiculo { get; set; } = null!;
}
