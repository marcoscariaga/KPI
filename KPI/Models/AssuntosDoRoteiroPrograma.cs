using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("AssuntosDoRoteiroPrograma")]
public partial class AssuntosDoRoteiroPrograma
{
    public int RoteiroId { get; set; }

    public int Ordem { get; set; }

    public int AssuntoId { get; set; }

    [ForeignKey("AssuntoId")]
    public virtual AssuntoPrograma Assunto { get; set; } = null!;

    [ForeignKey("RoteiroId")]
    public virtual RoteiroPrograma Roteiro { get; set; } = null!;
}
