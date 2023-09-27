using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("PerguntaDoAssuntoPrograma")]
[Index("PerguntaId", Name = "UQ__Pergunta__024FCC2577CAB889", IsUnique = true)]
public partial class PerguntaDoAssuntoPrograma
{
    public int AssuntoId { get; set; }

    public int Ordem { get; set; }

    public int PerguntaId { get; set; }

    [ForeignKey("AssuntoId")]
    public virtual AssuntoPrograma Assunto { get; set; } = null!;

    [ForeignKey("PerguntaId")]
    public virtual PerguntaPrograma Pergunta { get; set; } = null!;
}
