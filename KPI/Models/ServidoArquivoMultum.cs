using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

public partial class ServidoArquivoMultum
{
    public int? IdArquivoMulta { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string MatriculaDoServidor { get; set; } = null!;

    [ForeignKey("IdArquivoMulta")]
    [InverseProperty("ServidoArquivoMulta")]
    public virtual ArquivoMultum? IdArquivoMultaNavigation { get; set; }

    public virtual Servidor MatriculaDoServidorNavigation { get; set; } = null!;
}
