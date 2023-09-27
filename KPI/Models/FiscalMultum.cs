using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

public partial class FiscalMultum
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string MatriculaFiscal { get; set; } = null!;

    [StringLength(60)]
    [Unicode(false)]
    public string NomeFiscal { get; set; } = null!;

    public byte[]? ImagemAssinatura { get; set; }
}
