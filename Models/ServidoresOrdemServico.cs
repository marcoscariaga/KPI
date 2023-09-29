using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
[Table("ServidoresOrdemServico")]
[Index("ServidorId", Name = "gqs_servidorId")]
public partial class ServidoresOrdemServico
{
    public int OrdemServicoId { get; set; }

    public int ServidorId { get; set; }

    [ForeignKey("OrdemServicoId")]
    public virtual OrdemServico OrdemServico { get; set; } = null!;

    [ForeignKey("ServidorId")]
    public virtual Servidor Servidor { get; set; } = null!;
}
