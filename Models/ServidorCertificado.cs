using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("ServidorCertificado")]
public partial class ServidorCertificado
{
    [Key]
    public int Id { get; set; }

    public int IdDoServidor { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string NomeDoCertificado { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string SenhaDoCertificado { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataDeValidadeDoCertificado { get; set; }

    [ForeignKey("IdDoServidor")]
    [InverseProperty("ServidorCertificados")]
    public virtual Servidor IdDoServidorNavigation { get; set; } = null!;
}
