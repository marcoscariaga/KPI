using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Index("Descricao", Name = "UQ__Competen__008BA9EF5A1A5A11", IsUnique = true)]
public partial class Competencium
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    public int TipoClassificacaoCompetenciaId { get; set; }
}
