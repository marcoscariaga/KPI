using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("FaixaNumeracaoNotificacaoLaudo")]
[Index("Ano", Name = "UQ__FaixaNum__C697D3620C26B6F1", IsUnique = true)]
public partial class FaixaNumeracaoNotificacaoLaudo
{
    [Key]
    public int Id { get; set; }

    public int Ano { get; set; }

    public int UltimoNumeroUtilizado { get; set; }
}
