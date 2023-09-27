using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("FIlaEmail")]
public partial class FilaEmail
{
    [StringLength(200)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    public int Tipo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataAlteracao { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Observacao { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Nome { get; set; }

    public int? Situacao { get; set; }

    [Key]
    public int Id { get; set; }
}
