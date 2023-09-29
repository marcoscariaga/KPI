using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("ServidorInatividade")]
public partial class ServidorInatividade
{
    public int ServidorId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataInicio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataFim { get; set; }

    [ForeignKey("ServidorId")]
    public virtual Servidor Servidor { get; set; } = null!;
}
