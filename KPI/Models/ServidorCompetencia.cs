using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
public partial class ServidorCompetencia
{
    public int ServidorId { get; set; }

    public int CompetenciaId { get; set; }

    [ForeignKey("CompetenciaId")]
    public virtual Competencium Competencia { get; set; } = null!;

    [ForeignKey("ServidorId")]
    public virtual Servidor Servidor { get; set; } = null!;
}
