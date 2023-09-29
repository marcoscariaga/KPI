using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

public partial class FaixaDeNumeroCorreio
{
    [Key]
    public int Id { get; set; }

    public int FaixaInicial { get; set; }

    public int FaixaFinal { get; set; }

    public int? Atual { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataDaCriacao { get; set; }
}
