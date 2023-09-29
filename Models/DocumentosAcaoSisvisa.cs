using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("DocumentosAcaoSisvisa")]
public partial class DocumentosAcaoSisvisa
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string NomeArquivo { get; set; } = null!;

    public int AcaoSisvisaId { get; set; }

    [ForeignKey("AcaoSisvisaId")]
    [InverseProperty("DocumentosAcaoSisvisas")]
    public virtual AcaoSisvisa AcaoSisvisa { get; set; } = null!;
}
