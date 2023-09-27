using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("RequerenteTokenCPE")]
[Index("Token", "CodigoDaCpe", Name = "uq_RequerenteTokenCPE", IsUnique = true)]
public partial class RequerenteTokenCpe
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Token { get; set; } = null!;

    [Column("CodigoDaCPE")]
    [StringLength(20)]
    [Unicode(false)]
    public string CodigoDaCpe { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string NomeUsuario { get; set; } = null!;

    [StringLength(11)]
    [Unicode(false)]
    public string CpfUsuario { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DataEnvioEmail { get; set; }
}
