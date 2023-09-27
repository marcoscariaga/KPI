using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("SegmentosDaAcaoSisvisa")]
[Index("AcaoSisvisaId", "SegmentoId", Name = "UQ__Segmento__2769F63B73C51D7B", IsUnique = true)]
public partial class SegmentosDaAcaoSisvisa
{
    public int AcaoSisvisaId { get; set; }

    public int SegmentoId { get; set; }

    [ForeignKey("AcaoSisvisaId")]
    public virtual AcaoSisvisa AcaoSisvisa { get; set; } = null!;
}
