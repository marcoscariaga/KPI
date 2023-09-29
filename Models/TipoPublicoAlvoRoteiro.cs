using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("TipoPublicoAlvoRoteiro")]
[Index("TipoPublicoAlvoId", Name = "UQ__TipoPubl__A0504D3B2077C861", IsUnique = true)]
public partial class TipoPublicoAlvoRoteiro
{
    [Key]
    public int Id { get; set; }

    public int TipoPublicoAlvoId { get; set; }

    public int RoteiroId { get; set; }

    [ForeignKey("RoteiroId")]
    [InverseProperty("TipoPublicoAlvoRoteiros")]
    public virtual Roteiro Roteiro { get; set; } = null!;
}
