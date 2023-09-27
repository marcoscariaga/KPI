using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("VisitasDeInspecaoDoEstabelecimento")]
[Index("EstabelecimentoId", Name = "gqs_visitaInspEstab")]
public partial class VisitasDeInspecaoDoEstabelecimento
{
    public int EstabelecimentoId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataVisita { get; set; }

    public int AnoVisita { get; set; }

    public bool PrimeiraVisitaAnual { get; set; }

    public int TermoVisitaSanitariaId { get; set; }

    [ForeignKey("EstabelecimentoId")]
    public virtual Estabelecimento Estabelecimento { get; set; } = null!;

    [ForeignKey("TermoVisitaSanitariaId")]
    public virtual TermoVisitaSanitarium TermoVisitaSanitaria { get; set; } = null!;
}
