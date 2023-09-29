using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("PrioridadeDaAcaoSisvisa")]
[Index("TipoAcaoSisvisaId", Name = "UQ__Priorida__EC41047706B7F65E", IsUnique = true)]
public partial class PrioridadeDaAcaoSisvisa
{
    [Key]
    public int Id { get; set; }

    public int TipoAcaoSisvisaId { get; set; }

    public int Prioridade { get; set; }

    [InverseProperty("Prioridade")]
    public virtual ICollection<AcaoSisvisa> AcaoSisvisas { get; set; } = new List<AcaoSisvisa>();
}
