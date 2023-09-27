using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Keyless]
public partial class MultaArquivoMultum
{
    public int? IdMulta { get; set; }

    public int IdArquivo { get; set; }

    [ForeignKey("IdArquivo")]
    public virtual ArquivoMultum IdArquivoNavigation { get; set; } = null!;

    [ForeignKey("IdMulta")]
    public virtual Multum? IdMultaNavigation { get; set; }
}
