using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

public partial class AcaoSisvisaNaoConformidadePadronizadum
{
    [Key]
    public int Id { get; set; }

    public int AcaoSisvisaId { get; set; }

    public int NaoConformidadePadronizadaId { get; set; }

    [ForeignKey("AcaoSisvisaId")]
    [InverseProperty("AcaoSisvisaNaoConformidadePadronizada")]
    public virtual AcaoSisvisa AcaoSisvisa { get; set; } = null!;

    [ForeignKey("NaoConformidadePadronizadaId")]
    [InverseProperty("AcaoSisvisaNaoConformidadePadronizada")]
    public virtual NaoConformidadePadronizadum NaoConformidadePadronizada { get; set; } = null!;
}
