using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("PareceresDoRoteiroParaInspecao")]
public partial class PareceresDoRoteiroParaInspecao
{
    public int DemandaAcaoSisvisaId { get; set; }

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

    public int? PerguntaId { get; set; }

    public int? PerguntaProgramaId { get; set; }

    [ForeignKey("DemandaAcaoSisvisaId")]
    public virtual AcaoSisvisa DemandaAcaoSisvisa { get; set; } = null!;

    [ForeignKey("PerguntaId")]
    public virtual Perguntum? Pergunta { get; set; }

    [ForeignKey("PerguntaProgramaId")]
    public virtual PerguntaPrograma? PerguntaPrograma { get; set; }
}
