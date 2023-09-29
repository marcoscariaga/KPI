using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("PerguntasDoRoteiroPrograma")]
public partial class PerguntasDoRoteiroPrograma
{
    [Column("RoteiroPrograma_id")]
    public int RoteiroProgramaId { get; set; }

    [Column("PerguntaPrograma_id")]
    public int PerguntaProgramaId { get; set; }

    [ForeignKey("PerguntaProgramaId")]
    public virtual PerguntaPrograma PerguntaPrograma { get; set; } = null!;

    [ForeignKey("RoteiroProgramaId")]
    public virtual RoteiroPrograma RoteiroPrograma { get; set; } = null!;
}
