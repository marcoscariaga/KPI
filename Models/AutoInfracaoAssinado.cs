using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("AutoInfracaoAssinado")]
public partial class AutoInfracaoAssinado
{
    [Key]
    public int Id { get; set; }

    public int IdMulta { get; set; }

    public byte[] Documento { get; set; } = null!;

    [ForeignKey("IdMulta")]
    [InverseProperty("AutoInfracaoAssinados")]
    public virtual Multum IdMultaNavigation { get; set; } = null!;
}
