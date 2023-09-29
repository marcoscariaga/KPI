using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Index("Ano", Name = "UQ__FaixaNum__C697D36211F49EE0", IsUnique = true)]
public partial class FaixaNumeracaoO
{
    [Key]
    public int Id { get; set; }

    public int Ano { get; set; }

    public int UltimoNumeroOsUtilizado { get; set; }
}
