using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

public partial class TermoVigilanciaSanitarium
{
    [Key]
    public int Id { get; set; }

    [StringLength(500)]
    public string Titulo { get; set; } = null!;

    [StringLength(5000)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;
}
